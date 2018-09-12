using System.Data.SqlClient;
using System;



namespace WebApplication1
{
    public partial class Student: System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CHARAN-PC\\SQLEXPRESS;Initial Catalog=Db_KunfuMaster;Integrated Security=True");
            con.Open();
        }
        
        
        protected void Btn_register_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=CHARAN-PC\\SQLEXPRESS;Initial Catalog=Db_KunfuMaster;Integrated Security=True");
          /*  SqlTransaction transaction;*/
            con.Open();
           /* transaction = con.BeginTransaction();*/
            SqlCommand cmd = new SqlCommand("INSERT into Student_Details" + "(Stdnt_Id,Stdnt_First_Name,Stdnt_Last_Name,Stdnt_Date_of_Birth,Stdnt_Date_of_Joining,Stdnt_Mobile_No,Stdnt_Email,Stdnt_Door_No,Stdnt_Street,Stdnt_City ) VALUES (@Stdnt_Id,@Stdnt_First_Name,@Stdnt_Last_Name,@Stdnt_Date_of_Birth,@Stdnt_Date_of_Joining,@Stdnt_Mobile_No,@Stdnt_Email,@Stdnt_Door_No,@Stdnt_Street,@Stdnt_City)", con);
            /*"Stdnt_First_Name,Stdnt_Last_Name,Stdnt_Date_of_Birth ,Stdnt_Date_of_Joining,Stdnt_Mobile_No ,Stdnt_Email,Stdnt_Door_No,Stdnt_Street,Stdnt_City ,Stdnt_Province ,Stdnt_Zip_Code ,Stdnt_Primary_Contact,Stdnt_P_Contact_No,Stdnt_P_EmaiL ,Stdnt_Secondary_Contact,Stdnt_S_Contact_No,Stdnt_S_Email) " + 
            "VALUES (@Stdnt_Id", con);
                /*",@Stdnt_First_Name,@Stdnt_Last_Name,@Stdnt_Date_of_Birth ,@Stdnt_Date_of_Joining,@Stdnt_Mobile_No ,@Stdnt_Email,@Stdnt_Door_No,@Stdnt_Street,@Stdnt_City,@Stdnt_Province,@Stdnt_Zip_Code ,@Stdnt_Primary_Contact,@Stdnt_P_Contact_No,@Stdnt_P_EmaiL,@Stdnt_Secondary_Contact,@Stdnt_S_Contact_No,@Stdnt_S_Email)" , con); */
          
      

            cmd.Parameters.AddWithValue("@Stdnt_Id", Student_Number.Text);
            cmd.Parameters.AddWithValue("@Stdnt_First_Name", Student_Fname.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Last_Name", Student_Lname.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Date_of_Birth", Student_DOB.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Date_of_Joining", Student_DOJ.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Mobile_No", Student_Contact_No.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Email", Student_email.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Door_No", Student_Door_NO.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Street", Student_Street.Text);
            cmd.Parameters.AddWithValue("@Stdnt_City", Student_City.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Province", Student_Provinence.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Zip_Code", Student_Zipcode.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Primary_Contact", Student_PName.Text);
            cmd.Parameters.AddWithValue("@Stdnt_P_Contact_No", Student_PContact.Text);
            cmd.Parameters.AddWithValue("@Stdnt_P_EmaiL", Student_PEmail.Text);
            cmd.Parameters.AddWithValue("@Stdnt_Secondary_Contact", Student_SName.Text);
            cmd.Parameters.AddWithValue("@Stdnt_S_Contact_No", Student_SNumber.Text);
            cmd.Parameters.AddWithValue("@Stdnt_S_Email", Student_Semail.Text);
            
          
            cmd.ExecuteNonQuery();
           /* transaction.Commit();*/
           /* con.Close();*/
          
            Response.Redirect("index.html");
           
        }
    }
}