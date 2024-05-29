using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using ParkingSystemDesign.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ParkingSystemDesign.controller
{
    internal class DatabaseManager
    {
        private static String conString;
        private static SqlConnection con;
        private static SqlCommand cmd, selectCmd, updateCmd;
        private static SqlDataReader dr;
        private static string dbName = "ParkSys", usrTB = "Users", vhclTB = "Vehicles", sltTB = "Slots";
        private static string usrLgTB = "UserLogs", tranTB = "Transact";
        private static string userId = "", logId = "", vehicId = "", tranId = "";

        public static void initDB(String conStr)
        {
            conString = conStr;
            con = new SqlConnection(conString);
        }

        public static void openCon()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        public static void closeCon()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        public static void addReg(string lname, string fname, string mi, string user, string pass)
        {
            try
            {
                openCon();
                cmd = new SqlCommand("USE " + dbName + "; " +
                                     "INSERT INTO " + usrTB + "(userLN, userFN, userMI, userNm, userPW) " +
                                     "VALUES (@userLN, @userFN, @userMI, @userNm, @userPW); " +
                                     "SELECT SCOPE_IDENTITY();", con);

                cmd.Parameters.AddWithValue("@userLN", lname);
                cmd.Parameters.AddWithValue("@userFN", fname);
                cmd.Parameters.AddWithValue("@userMI", mi);
                cmd.Parameters.AddWithValue("@userNm", user);
                cmd.Parameters.AddWithValue("@userPW", pass);

                // Execute the command and capture the new userId
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToString(result);
                    MessageBox.Show("New User ID: " + userId, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to retrieve new user ID!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeCon();
            }
        }

        public static string fetchLogin(string user, string pass)
        {
            string query1 = "USE " + dbName + "; SELECT COUNT(*) FROM " + usrTB 
                + " WHERE userNm = @userNm;";
            string query2 = "USE " + dbName + "; SELECT userId FROM " + usrTB 
                + " WHERE userNm = @userNm AND userPW = @userPW;";

            int row = 0;
            userId = "";
            string status = "none";

            try
            {
                openCon();
                // Check if username exists
                cmd = new SqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@userNm", user);
                row = (int)cmd.ExecuteScalar();

                if (row > 0)
                {
                    // Check if username and password match
                    cmd = new SqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("@userNm", user);
                    cmd.Parameters.AddWithValue("@userPW", pass);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        userId = Convert.ToString(result);
                        return "all";
                    }
                    else
                    {
                        return "pass"; // Password incorrect
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeCon();
            }

            return status;
        }

        public static void addUsrLog(string dateTime)
        {
            try
            {
                openCon();
                cmd = new SqlCommand("USE " + dbName + "; " +
                                     "INSERT INTO " + usrLgTB + "(userId, logDate) " +
                                     "VALUES (@userId, @logDate); SELECT SCOPE_IDENTITY();", con);

                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@logDate", dateTime);

                // Execute the command and capture the new userId
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    logId = Convert.ToString(result);
                    MessageBox.Show("Log ID: " + logId, "User Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to process!", "User Logs Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeCon();
            }
        }

        public static bool existVPlate(string plateno)
        {
            string query = "USE " + dbName + "; SELECT COUNT(*) FROM "
                + vhclTB + " WHERE vehicPlate = @vehicPlate AND vehicParkoutT IS NULL;";
            int row = 0;

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@vehicPlate", plateno);
                row = (int)cmd.ExecuteScalar();

                return row > 0; // Return true if row count is greater than 0
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return false; // Return false if the plate does not exist or an error occurs
        }

        public static int getVCount()
        {
            int count = 0;
            string query = "USE " + dbName + "; SELECT COUNT(*) FROM " + vhclTB
                + " WHERE vehicParkoutT IS NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    count = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }
            return count;
        }

        public static List<string> getVPlate()
        {
            List<string> plateno = new List<string>();

            string query = "USE " + dbName + "; SELECT vehicPlate FROM "
                + vhclTB + " WHERE vehicParkoutT IS NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    plateno.Add(dr["vehicPlate"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return plateno;
        }

        public static List<string> getVType()
        {
            List<string> type = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicType FROM "
                + vhclTB + " WHERE vehicParkoutT IS NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    type.Add(dr["vehicType"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return type;
        }

        public static List<string> getVBrand()
        {
            List<string> brand = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicBrand FROM "
                + vhclTB + " WHERE vehicParkoutT IS NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    brand.Add(dr["vehicBrand"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return brand;
        }

        public static List<string> getVParkinT()
        {
            List<string> dtin = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicParkinT FROM "
                + vhclTB + " WHERE vehicParkoutT IS NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtin.Add(dr["vehicParkinT"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return dtin;
        }

        public static List<string> getVPlate1()
        {
            List<string> plateno = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicPlate FROM "
                + vhclTB + " WHERE vehicParkoutT IS NOT NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    plateno.Add(dr["vehicPlate"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return plateno;
        }

        public static List<string> getVType1()
        {
            List<string> type = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicType FROM "
                + vhclTB + " WHERE vehicParkoutT IS NOT NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    type.Add(dr["vehicType"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return type;
        }

        public static List<string> getVBrand1()
        {
            List<string> brand = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicBrand FROM "
                + vhclTB + " WHERE vehicParkoutT IS NOT NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    brand.Add(dr["vehicBrand"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return brand;
        }

        public static List<string> getVParkoutT1()
        {
            List<string> dtout = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicParkoutT FROM "
                + vhclTB + " WHERE vehicParkoutT IS NOT NULL;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtout.Add(dr["vehicParkoutT"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return dtout;
        }

        public static List<string> getVPlateHist()
        {
            List<string> plateno = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicPlate FROM " + vhclTB + ";";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    plateno.Add(dr["vehicPlate"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return plateno;
        }

        public static List<string> getVParkinTHist()
        {
            List<string> dtin = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicParkinT FROM " + vhclTB + ";";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtin.Add(dr["vehicParkinT"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return dtin;
        }

        public static List<string> getVParkoutTHist()
        {
            List<string> dtout = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicParkoutT FROM " + vhclTB + ";";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtout.Add(dr["vehicParkoutT"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return dtout;
        }

        public static List<string> getVTtlhrsHist()
        {
            List<string> hrs = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicTotalhrs FROM " + vhclTB + ";";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    hrs.Add(dr["vehicTotalhrs"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return hrs;
        }

        public static List<string> getVTtlamntHist()
        {
            List<string> amnt = new List<string>();
            string query = "USE " + dbName + "; SELECT vehicTotalamnt FROM " + vhclTB + ";";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    amnt.Add(dr["vehicTotalamnt"].ToString());
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }

            return amnt;
        }

        public static void addParkinV(string plateno, string type, string brand, string time)
        {
            try
            {
                openCon(); // Ensure the connection is opened before the loop

                cmd = new SqlCommand("USE " + dbName + "; INSERT INTO " + vhclTB + " (userId, vehicPlate, vehicType, vehicBrand, vehicParkinT) "
                        + "VALUES (@userId, @vehicPlate, @vehicType, @vehicBrand, @vehicParkinT); SELECT SCOPE_IDENTITY();", con);

                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@vehicPlate", plateno);
                cmd.Parameters.AddWithValue("@vehicType", type);
                cmd.Parameters.AddWithValue("@vehicBrand", brand);
                cmd.Parameters.AddWithValue("@vehicParkinT", time);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    vehicId = Convert.ToString(result);
                    MessageBox.Show("New Vehicle: " + plateno, "Parkin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction Failed!", "Parkin Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeCon(); // Ensure the connection is closed
            }
        }

        public static void deleteParkinV(string plateno)
        {
            try
            {
                openCon(); // Ensure the connection is opened

                // Retrieve the vehicId for the given vehicle plate
                string getVehicIdQuery = "USE " + dbName + "; SELECT vehicId FROM " + vhclTB + " WHERE vehicPlate = @vehicPlate;";
                cmd = new SqlCommand(getVehicIdQuery, con);
                cmd.Parameters.AddWithValue("@vehicPlate", plateno);

                int vehicId = 0;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vehicId = (int)dr["vehicId"];
                }
                dr.Close();

                if (vehicId == 0)
                {
                    MessageBox.Show("No vehicle found with the specified plate number!", "Parkin Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the dependent records in the Slots table
                string updateSlotsQuery = "USE " + dbName + "; UPDATE " + sltTB + " SET userId = NULL, vehicId = NULL, slotOccpncy = 0 WHERE vehicId = @vehicId;";
                cmd = new SqlCommand(updateSlotsQuery, con);
                cmd.Parameters.AddWithValue("@vehicId", vehicId);
                cmd.ExecuteNonQuery();

                // Delete the vehicle from the vhclTB table
                string deleteVehicleQuery = "USE " + dbName + "; DELETE FROM " + vhclTB + " WHERE vehicPlate = @vehicPlate;";
                cmd = new SqlCommand(deleteVehicleQuery, con);
                cmd.Parameters.AddWithValue("@vehicPlate", plateno);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deleted Vehicle: " + plateno, "Parkin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No vehicle found with the specified plate number!", "Parkin Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeCon(); // Ensure the connection is closed
            }
        }

        public static void insertVOutInfo(string plateno, string parkout, string ttlhrs, string ttlamnt)
        {
            try
            {
                openCon(); // Ensure the connection is opened before the loop

                cmd = new SqlCommand("USE " + dbName + "; UPDATE " + vhclTB + " SET vehicParkoutT = @vehicParkoutT, "
                    + "vehicTotalhrs = @vehicTotalhrs, vehicTotalamnt = @vehicTotalamnt WHERE vehicPlate = @vehicPlate;", con);

                cmd.Parameters.AddWithValue("@vehicPlate", plateno);
                cmd.Parameters.AddWithValue("@vehicParkoutT", parkout);
                cmd.Parameters.AddWithValue("@vehicTotalhrs", ttlhrs);
                cmd.Parameters.AddWithValue("@vehicTotalamnt", ttlamnt);

                object result = cmd.ExecuteScalar();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    vehicId = Convert.ToString(result);
                    MessageBox.Show("Park-out Vehicle: " + plateno, "Parkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No records updated!", "Parkout Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeCon(); // Ensure the connection is closed
            }
        }

        public static void parkSlot()
        {
            string query1 = "USE " + dbName + "; UPDATE TOP(1) " + sltTB + " SET userId = @userId, "
                + "vehicId = @vehicId, slotOccpncy = 1 WHERE slotOccpncy = 0; SELECT TOP 1 slotLoc FROM "
                + sltTB + " WHERE slotOccpncy = 1 AND vehicId = @vehicId ORDER BY slotId;";
            string parkedSlot = "";

            try
            {
                openCon(); // Open the database connection

                // Perform the update query
                cmd = new SqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@vehicId", vehicId);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    parkedSlot = dr["slotLoc"].ToString();
                    MessageBox.Show("Parked slot: " + parkedSlot, "Parking Slot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No available slot!", "Parking Slot Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeCon(); // Ensure to close the connection
            }
        }

        public static int getAvailSlt()
        {
            int count = 0;
            string query = "USE " + dbName + "; SELECT COUNT(*) FROM " + sltTB
                + " WHERE slotOccpncy = 0;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    count = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }
            return count;
        }

        public static int getOccpdSlt()
        {
            int count = 0;
            string query = "USE " + dbName + "; SELECT COUNT(*) FROM " + sltTB
                + " WHERE slotOccpncy = 1;";

            try
            {
                openCon(); // Ensure you have a method to open the connection
                cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    count = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Display any errors that occur
            }
            finally
            {
                closeCon(); // Ensure you have a method to close the connection
            }
            return count;
        }

        public static void exitSlot(string vehicPlate)
        {
            string selectQuery = "USE " + dbName + "; " +
                                 "SELECT s.slotId, s.slotLoc, v.vehicId " +
                                 "FROM " + sltTB + " s " +
                                 "INNER JOIN " + vhclTB + " v ON s.vehicId = v.vehicId " +
                                 "WHERE v.vehicPlate = @vehicPlate;";

            string updateQuery = "USE " + dbName + "; " +
                                 "UPDATE " + sltTB + " " +
                                 "SET userId = NULL, vehicId = NULL, slotOccpncy = 0 " +
                                 "WHERE slotOccpncy = 1 AND vehicId = (SELECT vehicId FROM " + vhclTB + " WHERE vehicPlate = @vehicPlate);";

            try
            {
                openCon(); // Open the database connection

                // First, execute the select query
                selectCmd = new SqlCommand(selectQuery, con);
                selectCmd.Parameters.AddWithValue("@vehicPlate", vehicPlate);

                SqlDataReader reader = selectCmd.ExecuteReader();
                string parkedSlot = "";
                if (reader.Read())
                {
                    parkedSlot = reader["slotLoc"].ToString();
                }
                reader.Close(); // Don't forget to close the reader

                // Next, execute the update query
                updateCmd = new SqlCommand(updateQuery, con);
                updateCmd.Parameters.AddWithValue("@vehicPlate", vehicPlate);

                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cleared slot: " + parkedSlot, "Parking Slot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No slot was cleared!", "Parking Slot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeCon(); // Close the database connection
            }
        }

        public static void addTransact(DateTime dt, string vehicPlate)
        {
            string joinQuery = "USE " + dbName + "; " +
                    "INSERT INTO " + tranTB + " (userId, vehicId, slotId, tranDate) " +
                    "SELECT u.userId, v.vehicId, s.slotId, @tranDate " +
                    "FROM " + vhclTB + " v " +
                    "INNER JOIN " + sltTB + " s ON v.vehicId = s.vehicId " +
                    "INNER JOIN " + usrTB + " u ON u.userId = s.userId " +
                    "WHERE v.vehicPlate = @vehicPlate; " +
                    "SELECT SCOPE_IDENTITY();";

            try
            {
                con.Open();
                cmd = new SqlCommand(joinQuery, con);
                cmd.Parameters.AddWithValue("@tranDate", dt);
                cmd.Parameters.AddWithValue("@vehicPlate", vehicPlate);

                // Execute the query and get the inserted transaction ID
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tranId = Convert.ToString(result);
                    MessageBox.Show("Transaction ID: " + tranId, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction Failed!", "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("A database error occurred: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    con.Close(); // Ensure to close the connection
                }
            }
        }
    }
}
