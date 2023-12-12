using Npgsql;
using System.Data;

namespace ResponsiBlk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_load(object sender, EventArgs e)
        {
            con = new NpgsqlConnection(connstring);
        }

        private NpgsqlConnection con;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=ResponsiHR";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sql = @"select * from st.insert (:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("name", namaTb.Text);
                cmd.Parameters.AddWithValue("id_dep", depCb.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Done");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Fail!" + "error: " + ex.Message);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();


                con .Close();

            }
            catch (Exception ex)
            {

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con .Open();
                sql = "select * from st_delete(:_id)";
                cmd = new NpgsqlCommand(sql,con);
                cmd.Parameters.AddWithValue(":_id_dep", r.Cells["_id"].Value.ToString());
                if ((int)cmd.ExecuteScalar() != 1)
                {
                    MessageBox.Show("Data berhasil dihapus");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Fail!", "error: " + ex.Message);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                viewDGV.DataSource = null;
                sql = "select * from st_select";
                cmd = new NpgsqlCommand(sql, con);
                dt = new DataTable();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                viewDGV.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gagal Loading data" + ex.Message);
            }
        }
    }
}
