using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Scrap.Librarys
{
    class Scrap
    {
        #region private variables
        private int are_id;
        private string area;
        private int proceso;
        private string codigo;
        private int num_id;
        private int lea_id;
        private string numparte;
        private string lead;
        private int componente_id;
        private string componente;
        private string turno;
        private int cantidad;
        #endregion

        #region public variables
        public int Are_id { get => are_id; set => are_id = value; }
        public string Area { get => area; set => area = value; }
        public int Proceso { get => proceso; set => proceso = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Lea_id { get => lea_id; set => lea_id = value; }
        public string Lead { get => lead; set => lead = value; }
        public int Componente_id { get => componente_id; set => componente_id = value; }
        public string Componente { get => componente; set => componente = value; }
        public string Turno { get => turno; set => turno = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Numparte { get => numparte; set => numparte = value; }
        public int Num_id { get => num_id; set => num_id = value; }
        #endregion
        public DataTable SelectAreas()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT ARE_ID AS ID, ARE_AREA AS AREA FROM AREAS 
                           WHERE ESTADO = 'ACTIVO'
                           ORDER BY CAST(ARE_AREA AS UNSIGNED),  ARE_AREA ASC";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //cmd.Parameters.AddWithValue("maq_id", maq_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectLineas(int are_id, string sub)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT MAQ_ID AS ID, CONCAT_WS('-', MAQ_LADO, MAQ_NUMERO) AS LINEA
                            FROM MAQUINARIA WHERE ARE_ID=?are_id
                            AND TIPMAQ_ID=2 AND STATUS='ACTIVO'" + sub;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("are_id", are_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectLineassearch(int are_id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT M.MAQ_ID AS ID, CONCAT_WS('-', M.MAQ_LADO, MAQ_NUMERO) AS MAQUINA
                           FROM MAQUINARIA M
                           WHERE M.ARE_ID=?are_id AND TIPMAQ_ID =2 
					       AND M.STATUS = 'ACTIVO' ORDER BY M.MAQ_NUMERO, M.MAQ_LADO";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("are_id", are_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectNumparte(int maq_id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT N.NUM_ID AS ID, N.NUM_NUMPARTE AS NP 
                            FROM numparte N
                            INNER JOIN npmaquina NM ON NM.num_id = N.num_id
                            INNER JOIN maquinaria M ON M.maq_id = NM.maq_id
                            WHERE M.MAQ_ID=?maq_id";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("maq_id", maq_id);
                //cmd.Parameters.AddWithValue("lea_id", lea_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectNumparteLeads(int num_id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT L.LEA_ID AS ID, L.LEA_LEAD AS LEAD FROM LEADS L
                             INNER JOIN NPLEAD NL ON NL.LEA_ID = L.LEA_ID
                             WHERE NL.NUM_ID=?numid";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("numid", num_id);
                //cmd.Parameters.AddWithValue("lea_id", lea_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectProcesos()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT PROC_ID AS ID, PROC_PROCESO AS PROCESO FROM PROCESOS 
                           WHERE (PROC_ID = 3 OR PROC_ID = 4 OR PROC_ID = 7 OR PROC_ID = 12)";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //cmd.Parameters.AddWithValue("are_id", are_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectProcesosL8()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT PROC_ID AS ID, PROC_PROCESO AS PROCESO FROM PROCESOS 
                           WHERE (PROC_ID = 22 OR PROC_ID = 23 OR PROC_ID = 24)";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("are_id", are_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public List<string>[] LeadsNp(string lead, int maq_id)
        {
            int regresa = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT DISTINCT N.NUM_ID AS ID, N.NUM_NUMPARTE AS NP FROM NUMPARTE N
                            INNER JOIN NPMAQUINA NPM ON N.NUM_ID = NPM.NUM_ID
                            INNER JOIN MAQUINARIA M ON NPM.MAQ_ID = M.MAQ_ID
                            INNER JOIN NPLEAD NPL ON NPL.NUM_ID = N.NUM_ID
                            INNER JOIN LEADS L ON L.LEA_ID = NPL.LEA_ID
                            WHERE M.MAQ_ID=?maq_id
                            AND L.LEA_LEAD=?lead";

            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("maq_id", maq_id);
                cmd.Parameters.AddWithValue("lead", lead);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    
                    while (dr.Read())
                    {
                        list[0].Add(dr["ID"] + "");
                        list[1].Add(dr["NP"] + "");

                        regresa++;
                    }

                }
                dr.Close();
                connection.Close();

                return list;
            }
        }
        public int BuscaLeads(int maq_id, string lea)
        {
            int qty = 0;

            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT L.LEA_ID, L.LEA_LEAD, N.NUM_ID FROM NUMPARTE N
                            INNER JOIN NPMAQUINA NPM ON N.NUM_ID = NPM.NUM_ID
                            INNER JOIN MAQUINARIA M ON NPM.MAQ_ID = M.MAQ_ID
                            INNER JOIN NPLEAD NPL ON NPL.NUM_ID = N.NUM_ID
                            INNER JOIN LEADS L ON L.LEA_ID = NPL.LEA_ID
                            WHERE M.MAQ_ID=?maq_id
                            AND L.LEA_LEAD=?lead";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("maq_id", maq_id);
                cmd.Parameters.AddWithValue("lead", lea);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        lea_id = int.Parse(dr[0].ToString());
                        lead = dr[1].ToString();
                        num_id = int.Parse(dr[2].ToString());
                        qty++;
                    }

                }

                connection.Close();
            }

            return qty;
        }
        public List<string>[] NumLeads(int num_id)
        {
            int regresa = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT NL.LEA_ID AS ID, L.LEA_LEAD AS LEAD FROM NPLEAD NL
                           INNER JOIN LEADS L ON L.LEA_ID = NL.LEA_ID
                           WHERE NUM_ID=?num_id";

            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("num_id", num_id);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        list[0].Add(dr["ID"] + "");
                        list[1].Add(dr["LEAD"] + "");

                        regresa++;
                    }

                }
                dr.Close();
                connection.Close();

                return list;
            }
        }
        public int Np(string np)
        {
            int numid = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT NUM_ID FROM NUMPARTE
                           WHERE NUM_NUMPARTE=?np";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("np", np);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        numid = int.Parse(dr[0].ToString());
                    }

                }

                connection.Close();
            }

            return numid;
        }
        public int IdLead(string lea)
        {
            int id = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT LEA_ID FROM LEADS
                           WHERE LEA_LEAD=?lead";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("lead", lea);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        id = int.Parse(dr[0].ToString());
                    }

                }

                connection.Close();
            }

            return id;
        }
        public DataTable SelectSubprocesos(int id_pro, string lea_id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT DISTINCT(S.ID) AS ID, UPPER(S.SUBPROCESO) AS  SUBPROCESO
                          FROM PROCESOS P
                          INNER JOIN PROCESOSUBPROCESO PS ON PS.ID_PROCESO = P.PROC_ID
                          INNER JOIN SUBPROCESOS S ON S.ID = PS.ID_SUBPROCESO
                          INNER JOIN tblcomponenteestacion CE ON CE.are_id = PS.id_subproceso
                          WHERE P.PROC_ID <=?id_pro
                          AND CE.lea_id =?lea_id";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id_pro", id_pro);
                cmd.Parameters.AddWithValue("lea_id", lea_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectDefectos(int idPro, int negocio)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT de.defecto_id AS ID, UPPER(CONCAT_WS(' - ', de.codigo, de.defecto)) AS DEFECTO
                            FROM tbldefectos de
                            INNER JOIN proceso_defectos pd ON pd.DEFECTO_ID = de.defecto_id
                            WHERE pd.PROC_ID=?idPro
                            AND de.negocio=?negocio
                            AND de.estado = 1";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("idPro", idPro);
                cmd.Parameters.AddWithValue("negocio", negocio);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SearchListComponents(string lead)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT CE.comp_id AS ID, UPPER(S.subproceso) AS PROCESO, C.componente AS COMPONENTE, CE.cantidad AS QTY, C.um AS UNIDAD, 
                            UPPER(C.description) AS DESCRIPCCION, C.current_cost AS COSTO, CE.orden AS SECUENCIA
                            FROM tblcomponenteestacion CE
                            INNER JOIN subprocesos S ON S.id = CE.are_id
                            INNER JOIN tblcomponentes C ON C.id =CE.comp_id
                            WHERE CE.LEA_ID =?lead
                            ORDER BY CAST(CE.ORDEN AS SIGNED)";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("lead", lead);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectComponentesNp(string np)
        {
            List<string>[] listLeads = new List<string>[2];
            listLeads = NumLeads(np);

            List<string>[] listLlaves = new List<string>[1];
            listLlaves = NpFull(listLeads);
            int Ql = listLlaves[0].Count;

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("LEAD", typeof(string));
            table.Columns.Add("PROCESO", typeof(string));
            table.Columns.Add("COMPONENTE", typeof(string));
            table.Columns.Add("QTY", typeof(string));
            table.Columns.Add("UNIDAD", typeof(string));
            table.Columns.Add("DESCRIPCCION", typeof(string));
            table.Columns.Add("COSTO", typeof(string));
            table.Columns.Add("SECUENCIA", typeof(int));

            List<string>[] list = new List<string>[7];

            List<string>[] listRegresa = new List<string>[9];
            listRegresa[0] = new List<string>();
            listRegresa[1] = new List<string>();
            listRegresa[2] = new List<string>();
            listRegresa[3] = new List<string>();
            listRegresa[4] = new List<string>();
            listRegresa[5] = new List<string>();
            listRegresa[6] = new List<string>();
            listRegresa[7] = new List<string>();
            listRegresa[8] = new List<string>();
            //int j = 0;
            for (int k = 0; k < Ql; k++)
            {
                //recorrer la lista
                list = SelectListComponentesView(listLlaves[0][k]);
                for (int h = 0; h < list[0].Count; h++)
                {
                    listRegresa[0].Add(list[0][h] + "");
                    if (list[1][h] == "")
                    {
                        listRegresa[1].Add(np + "");
                    }
                    else
                    {
                        listRegresa[1].Add(list[1][h] + "");
                    }
                    listRegresa[2].Add(list[2][h] + "");
                    listRegresa[3].Add(list[3][h] + "");
                    listRegresa[4].Add(list[4][h] + "");
                    listRegresa[5].Add(list[5][h] + "");
                    listRegresa[6].Add(list[6][h] + "");
                    listRegresa[7].Add(list[7][h] + "");
                    listRegresa[8].Add(list[8][h] + "");
                    //j++;
                }
            }



            for (int i = 0; i < listRegresa[0].Count; i++)
            {
                DataRow row = table.NewRow();

                row["ID"] = int.Parse(listRegresa[0][i]);
                row["LEAD"] = listRegresa[1][i];
                row["PROCESO"] = listRegresa[2][i];
                row["COMPONENTE"] = listRegresa[3][i];
                row["QTY"] = listRegresa[4][i];
                row["UNIDAD"] = listRegresa[5][i];
                row["DESCRIPCCION"] = listRegresa[6][i];
                row["COSTO"] = listRegresa[7][i];
                row["SECUENCIA"] = listRegresa[8][i];
                //row["CHECK"] = true;

                table.Rows.Add(row);
            }
            return table;
        }
        public List<string>[] SelectListComponentesView(string lea_id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT CE.ID AS ID, L.lea_lead AS LEAD, UPPER(S.subproceso) AS PROCESO, C.componente AS COMPONENTE, 
                            CE.cantidad AS QTY, C.um AS UNIDAD, 
                            UPPER(C.description) AS DESCRIPCCION, C.current_cost AS COSTO, CE.orden AS SECUENCIA
                            FROM tblcomponenteestacion CE
                            INNER JOIN subprocesos S ON S.id = CE.are_id
                            INNER JOIN tblcomponentes C ON C.id =CE.comp_id
                            LEFT JOIN leads L ON L.lea_id = CE.lea_id
                            WHERE CE.LEA_ID =?lea_id
                            AND CE.ORDEN > 0
                            ORDER BY CAST(CE.ORDEN AS SIGNED)";

            List<string>[] list = new List<string>[9];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("lea_id", lea_id);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID"] + "");
                    list[1].Add(dataReader["LEAD"] + "");
                    list[2].Add(dataReader["PROCESO"] + "");
                    list[3].Add(dataReader["COMPONENTE"] + "");
                    list[4].Add(dataReader["QTY"] + "");
                    list[5].Add(dataReader["UNIDAD"] + "");
                    list[6].Add(dataReader["DESCRIPCCION"] + "");
                    list[7].Add(dataReader["COSTO"] + "");
                    list[8].Add(dataReader["SECUENCIA"] + "");

                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.Close();

                //return list
                return list;
            }
        }
        public DataTable SearchListComponentsView(string lead)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT CE.ID AS ID, L.lea_lead AS LEAD, UPPER(S.subproceso) AS PROCESO, C.componente AS COMPONENTE, CE.cantidad AS QTY, C.um AS UNIDAD, 
                            UPPER(C.description) AS DESCRIPCCION, C.current_cost AS COSTO, CE.orden AS SECUENCIA
                            FROM tblcomponenteestacion CE
                            INNER JOIN subprocesos S ON S.id = CE.are_id
                            INNER JOIN tblcomponentes C ON C.id =CE.comp_id
                            INNER JOIN leads L ON L.lea_id = CE.lea_id
                            WHERE CE.LEA_ID =?lead
                            ORDER BY CAST(CE.ORDEN AS SIGNED)";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("lead", lead);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public List<string>[] NumLeads(string np)
        {
            int regresa = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT NL.LEA_ID AS ID, L.LEA_LEAD AS LEAD 
                           FROM NPLEAD NL
                           INNER JOIN LEADS L ON L.LEA_ID = NL.LEA_ID
                           INNER JOIN NUMPARTE N ON N.NUM_ID = NL.NUM_ID
                           WHERE N.NUM_NUMPARTE=?np";

            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("np", np);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        list[0].Add(dr["ID"] + "");
                        list[1].Add(dr["LEAD"] + "");

                        regresa++;
                    }

                }
                dr.Close();
                connection.Close();

                return list;
            }
        }
        public List<string>[] SelectListComponentes(int idSub, string lea_id, int sec)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT CE.comp_id AS ID, L.lea_lead AS LEAD, UPPER(S.subproceso) AS PROCESO, C.componente AS COMPONENTE, CE.cantidad AS QTY, C.um AS UNIDAD, 
                            UPPER(C.description) AS DESCRIPCCION, C.current_cost AS COSTO, CE.orden AS SECUENCIA
                            FROM tblcomponenteestacion CE
                            INNER JOIN subprocesos S ON S.id = CE.are_id
                            INNER JOIN tblcomponentes C ON C.id =CE.comp_id
                            INNER JOIN leads L ON L.lea_id = CE.lea_id
                            WHERE CE.lea_id =?lea_id
                            AND CE.orden <=?orden
                            ORDER BY CE.ID";

            List<string>[] list = new List<string>[9];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("lea_id", lea_id);
                cmd.Parameters.AddWithValue("idSub", idSub);
                cmd.Parameters.AddWithValue("orden", sec);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID"] + "");
                    list[1].Add(dataReader["LEAD"] + "");
                    list[2].Add(dataReader["PROCESO"] + "");
                    list[3].Add(dataReader["COMPONENTE"] + "");
                    list[4].Add(dataReader["QTY"] + "");
                    list[5].Add(dataReader["UNIDAD"] + "");
                    list[6].Add(dataReader["DESCRIPCCION"] + "");
                    list[7].Add(dataReader["COSTO"] + "");
                    list[8].Add(dataReader["SECUENCIA"] + "");

                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.Close();

                //return list
                return list;
            }
        }
        public DataTable SelectComponentes(int idSub, string lea_id, int sec)
        {

            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("LEAD", typeof(string));
            table.Columns.Add("PROCESO", typeof(string));
            table.Columns.Add("COMPONENTE", typeof(string));
            table.Columns.Add("QTY", typeof(string));
            table.Columns.Add("UNIDAD", typeof(string));
            table.Columns.Add("DESCRIPCCION", typeof(string));
            table.Columns.Add("COSTO", typeof(string));
            table.Columns.Add("SECUENCIA", typeof(int));
            table.Columns.Add("CHECK", typeof(bool));

            List<string>[] list = new List<string>[9];
            list = SelectListComponentes(idSub, lea_id, sec);

            for (int i = 0; i < list[0].Count; i++)
            {
                DataRow row = table.NewRow();

                row["ID"] = int.Parse(list[0][i]);
                row["LEAD"] = list[1][i];
                row["PROCESO"] = list[2][i];
                row["COMPONENTE"] = list[3][i];
                row["QTY"] = list[4][i];
                row["UNIDAD"] = list[5][i];
                row["DESCRIPCCION"] = list[6][i];
                row["COSTO"] = list[7][i];
                row["SECUENCIA"] = list[8][i];
                row["CHECK"] = true;

                table.Rows.Add(row);
            }
            return table;
        }
        public string RegresaLlave(List<string>[] codigos, int qty)
        {
            string key = "";

            for(int i =0; i < qty; i++)
            {
                key = key + codigos[0][i];
            }

            return key;
        }
        public int Secuencia(string key, int proceso)
        {
            int secuencia = 0;


            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT orden FROM tblcomponenteestacion 
                             WHERE lea_id =?lea_id AND are_id =?idPro";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("lea_id", key);
                cmd.Parameters.AddWithValue("idPro", proceso);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        secuencia = int.Parse(dr[0].ToString());
                    }

                }

                connection.Close();
            }

            return secuencia;
        }
        public DataTable SelectLeadsLinea(int maq_id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT DISTINCT(LEA_LEAD) AS lead
								FROM LEADS L
								INNER JOIN nplead nl ON nl.lea_id = L.lea_id
								INNER JOIN npmaquina nm ON nm.num_id = nl.num_id
								INNER JOIN maquinaria m ON m.maq_id = nm.maq_id
								WHERE m.maq_id =?maq_id
								ORDER BY L.LEA_LEAD";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("maq_id", maq_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public DataTable SelectComponentes()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT ID, CONCAT_WS(' - ', COMPONENTE, DESCRIPTION) AS COMPONENTE FROM TBLCOMPONENTES";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //cmd.Parameters.AddWithValue("maq_id", maq_id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
        public string GetId(string combo)
        {
            string[] id = combo.Split('-');
            string regresa = id[0];

            return regresa;
        }
        public bool ValidateText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;
            else
                return true;
        }
        private string SelectFecha()
        {
            string hora = "";
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT  DATE_FORMAT(NOW(), '%T') AS HORA";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        hora = dr[0].ToString();
                    }

                }

                connection.Close();
            }

            return hora;
        }
        public string SelectFechaCompleta()
        {
            string fecha = "";
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT DATE_FORMAT(NOW(), '%Y-%m-%d %H:%i:%s') AS FECHA";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {

                    while (dr.Read())
                    {
                        fecha = dr[0].ToString();
                    }

                }

                connection.Close();
            }

            return fecha;
        }
        public string Shift()
        {
            string horaActual = SelectFecha();

            string shift = "";
            string[] divide = horaActual.Split(':');

            int hora = int.Parse(divide[0]);
            int minuto = int.Parse(divide[1]);
            int segundo = int.Parse(divide[2]);

            if(hora >= 7 && hora <= 18)
            {
                if(minuto >= 0 && minuto <= 59)
                {
                    if(segundo >= 0 && segundo <= 59)
                    {
                        shift = "A";
                    }   
                }
            }
            else
            {
                shift = "B";
            }

            return shift;
        }
        public DataTable SelectComponentesNp(int np, string sec)
        {
            List<string>[] listLeads = new List<string>[2];
            listLeads = NumLeads(np);

            List<string>[] listLlaves = new List<string>[1];
            listLlaves = NpFull(listLeads);
            int Ql = listLlaves[0].Count;

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("LEAD", typeof(string));
            table.Columns.Add("PROCESO", typeof(string));
            table.Columns.Add("COMPONENTE", typeof(string));
            table.Columns.Add("QTY", typeof(string));
            table.Columns.Add("UNIDAD", typeof(string));
            table.Columns.Add("DESCRIPCCION", typeof(string));
            table.Columns.Add("COSTO", typeof(string));
            table.Columns.Add("SECUENCIA", typeof(int));
            table.Columns.Add("CHECK", typeof(bool));

            List<string>[] list = new List<string>[9];

            List<string>[] listRegresa = new List<string>[9];
            listRegresa[0] = new List<string>();
            listRegresa[1] = new List<string>();
            listRegresa[2] = new List<string>();
            listRegresa[3] = new List<string>();
            listRegresa[4] = new List<string>();
            listRegresa[5] = new List<string>();
            listRegresa[6] = new List<string>();
            listRegresa[7] = new List<string>();
            listRegresa[8] = new List<string>();
            //int j = 0;
            for (int k = 0; k < Ql; k++)
            {
                //recorrer la lista
                if(k == Ql - 1)
                {
                    list = SelectListComponentes(listLlaves[0][k], sec);
                }
                else
                {
                    list = SelectListComponentes(listLlaves[0][k], " AND CE.ORDEN > 0 ");
                }

                for (int h = 0; h < list[0].Count; h++)
                {
                    listRegresa[0].Add(list[0][h] + "");
                    if (list[1][h] == "")
                    {
                        listRegresa[1].Add(np + "");
                    }
                    else
                    {
                        listRegresa[1].Add(list[1][h] + "");
                    }
                    listRegresa[2].Add(list[2][h] + "");
                    listRegresa[3].Add(list[3][h] + "");
                    listRegresa[4].Add(list[4][h] + "");
                    listRegresa[5].Add(list[5][h] + "");
                    listRegresa[6].Add(list[6][h] + "");
                    listRegresa[7].Add(list[7][h] + "");
                    listRegresa[8].Add(list[8][h] + "");
                    //j++;
                }
            }

            for (int i = 0; i < listRegresa[0].Count; i++)
            {
                DataRow row = table.NewRow();

                row["ID"] = int.Parse(listRegresa[0][i]);
                row["LEAD"] = listRegresa[1][i];
                row["PROCESO"] = listRegresa[2][i];
                row["COMPONENTE"] = listRegresa[3][i];
                row["QTY"] = listRegresa[4][i];
                row["UNIDAD"] = listRegresa[5][i];
                row["DESCRIPCCION"] = listRegresa[6][i];
                row["COSTO"] = listRegresa[7][i];
                row["SECUENCIA"] = listRegresa[8][i];
                row["CHECK"] = true;

                table.Rows.Add(row);
            }
            return table;
        }
        public List<string>[] NpFull(List<string>[] codigo)
        {
            List<string>[] list = new List<string>[1];
            list[0] = new List<string>();
            int c = codigo[0].Count;
            c++;

            string key = RegresaLlave(codigo, codigo[0].Count);

            for (int i = 0; i < c; i++)
            {
                if (i < codigo[0].Count)
                    list[0].Add(codigo[0][i] + "");
                else
                    list[0].Add(key + "");
            }


            return list;
        }
        public List<string>[] SelectListComponentes(string lea_id, string sec)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT C.ID AS ID, L.lea_lead AS LEAD, UPPER(S.subproceso) AS PROCESO, C.componente AS COMPONENTE, 
                            CE.cantidad AS QTY, C.um AS UNIDAD, 
                            UPPER(C.description) AS DESCRIPCCION, C.current_cost AS COSTO, CE.orden AS SECUENCIA
                            FROM tblcomponenteestacion CE
                            INNER JOIN subprocesos S ON S.id = CE.are_id
                            INNER JOIN tblcomponentes C ON C.id =CE.comp_id
                            LEFT JOIN leads L ON L.lea_id = CE.lea_id
                            WHERE CE.LEA_ID =?lea_id " + 
                            sec + 
                            " ORDER BY CAST(CE.ORDEN AS SIGNED)";

            List<string>[] list = new List<string>[9];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();
            list[8] = new List<string>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("lea_id", lea_id);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID"] + "");
                    list[1].Add(dataReader["LEAD"] + "");
                    list[2].Add(dataReader["PROCESO"] + "");
                    list[3].Add(dataReader["COMPONENTE"] + "");
                    list[4].Add(dataReader["QTY"] + "");
                    list[5].Add(dataReader["UNIDAD"] + "");
                    list[6].Add(dataReader["DESCRIPCCION"] + "");
                    list[7].Add(dataReader["COSTO"] + "");
                    list[8].Add(dataReader["SECUENCIA"] + "");

                }
                //close Data Reader
                dataReader.Close();

                //close Connection
                connection.Close();

                //return list
                return list;
            }
        }
        #region Insert
        public Int64 InsertDefecto(string consecutivo, int num_id, int lea_id, int id_pro, int id_estacion, int id_linea, int cantidad,
                                  int capturista, string turno, string defecto, int orden, string config, string fecha)
        {
            int id = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"insert into tblscrap(consecutivo, num_id, lead_id, id_pro, id_estacion, comp_id, cantidad, costo, empleado, turno, defecto, fecha, orden)
                         values(?conse, ?num_id, ?lea_id, ?id_pro, ?id_estacion, ?id_linea, ?cantidad,?config, ?empleado, ?turno, ?defecto, ?fecha, ?orden)";
            //open connection
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?conse", MySqlDbType.VarChar).Value = consecutivo;
                cmd.Parameters.Add("?num_id", MySqlDbType.Int32).Value = num_id;
                cmd.Parameters.Add("?lea_id", MySqlDbType.Int32).Value = lea_id;
                cmd.Parameters.Add("?id_pro", MySqlDbType.Int32).Value = id_pro;
                cmd.Parameters.Add("?id_estacion", MySqlDbType.Int32).Value = id_estacion;
                cmd.Parameters.Add("?id_linea", MySqlDbType.Int16).Value = id_linea;
                cmd.Parameters.Add("?cantidad", MySqlDbType.Int16).Value = cantidad;
                cmd.Parameters.Add("?empleado", MySqlDbType.Int32).Value = capturista;
                cmd.Parameters.Add("?turno", MySqlDbType.VarChar).Value = turno;
                cmd.Parameters.Add("?defecto", MySqlDbType.VarChar).Value = defecto;
                cmd.Parameters.Add("?orden", MySqlDbType.Int16).Value = orden;
                cmd.Parameters.Add("?config", MySqlDbType.VarChar).Value = config;
                cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha;

                //Execute command
                cmd.ExecuteNonQuery();
                if (cmd.LastInsertedId != null)
                    cmd.Parameters.Add(new MySqlParameter("newId", cmd.LastInsertedId));
                id = Convert.ToInt32(cmd.Parameters["@newId"].Value);

                connection.Close();
            }

            return id;
        }
        public int InsertScrapComponentes(Int64 consecutivo, int idcomp, float qty)
        {
            int id = 0;
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"insert into tblscrapcomponentes(consecutivo, id_componente, cantidad, fecha) 
                                                   values(?cons, ?idcomp, ?cantidad, DATE_FORMAT(NOW(), '%Y-%m-%d'))";
            //open connection
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?cons", MySqlDbType.Int64).Value = consecutivo;
                cmd.Parameters.Add("?idcomp", MySqlDbType.Int32).Value = idcomp;
                cmd.Parameters.Add("?cantidad", MySqlDbType.Float).Value = qty;

                //Execute command
                cmd.ExecuteNonQuery();
                if (cmd.LastInsertedId != null)
                    cmd.Parameters.Add(new MySqlParameter("newId", cmd.LastInsertedId));
                id = Convert.ToInt32(cmd.Parameters["@newId"].Value);

                connection.Close();
            }

            return id;
        }
        #endregion
        public DataTable ValuesFilter(bool[] componente, string[] valores)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ToString();

            string condicion = "";

            if (valores.All(item => item == null))
            {

            }
            else
            {
                if (componente[0] == true && componente[3] == true && componente[4] == true)
                {
                    condicion += " AND M.ARE_ID=" + valores[0] + " AND DATE_FORMAT(FECHA, '%Y-%m-%d')>= '" + valores[3] + "' AND DATE_FORMAT(FECHA, '%Y-%m-%d')<='" + 
                        valores[4] + "'";
                    if (componente[2] == true) condicion += " AND U.USU_PLACAS= '" + valores[2] + "'";
                    if (componente[5] == true) condicion += " AND TURNO= '" + valores[5] + "'";
                }
                /*filtra por rango de fechas, sin tomar en cuenta el turno*/
                /*else if (componente[0] == true && componente[1] == true && componente[3] == true && componente[4] == true)
                {
                    condicion += " AND M.ARE_ID=" + valores[0] + " AND  DATE_FORMAT(FECHA, 'yyyy-MM-dd')>= '" + valores[3] + 
                                 "' AND DATE_FORMAT(FECHA, 'yyyy-MM-dd')<='" + valores[4] + "'" + " ";
                }
                //filtra solo por una fecha en especifico sin tomar encuenta el turno
                else if (componente[0] == true && componente[1] == true && componente[2] == false && componente[3] == false)
                {
                    condicion += " AND DEVICE=" + valores[0];
                    if (componente[1] == true && componente[2] == false) condicion += " AND FORMAT(TIME_STAMP, 'yyyy-MM-dd')= '" + valores[1] + "'";
                    if (componente[1] == false && componente[2] == true) condicion += " AND FORMAT(TIME_STAMP, 'yyyy-MM-dd')<= '" + valores[2] + "'";
                    if (componente[1] == true && componente[2] == true) condicion += " AND  FORMAT(TIME_STAMP, 'yyyy-MM-dd')>= '" + valores[1] + "' AND FORMAT(TIME_STAMP, 'yyyy-MM-dd')<='" + valores[2] + "'";
                }
                //filtra for la primera fecha y por turno
                else if (componente[0] == true && componente[1] == true && componente[2] == false && componente[3] == true)
                {
                    condicion += " AND DEVICE=" + valores[0];
                    if (valores[3] == "A")
                        condicion += " AND FORMAT(TIME_STAMP, 'yyyy-MM-dd')= '" + valores[1] + "'" + " AND (FORMAT(TIME_STAMP, 'HH') >= 7 AND FORMAT(TIME_STAMP, 'HH') < 19)";
                    else
                        condicion += " AND (FORMAT(TIME_STAMP, 'yyyy-MM-dd') >= '" + valores[1] + "'" +
                                  " AND FORMAT(TIME_STAMP, 'yyyy-MM-dd')<= '" + valores[1] + "')" +
                                  " AND (FORMAT(TIME_STAMP, 'HH') >= 19 AND FORMAT(TIME_STAMP, 'HH') <= 23) " +
                                  " UNION " +
                                  " SELECT ID, DIAMETER, DISTANCE, DISTANCE, dbo.NO_REFERENCIA(DISTANCE, STATUS) AS STATUS, COUNTER, JOB, IMAGE, INSERTDATE " +
                                  " FROM [opc].[dbo].[CONCENTRICITY] " +
                                  " WHERE(FORMAT(TIME_STAMP, 'yyyy-MM-dd') >= DATEADD(DAY, 1, '" + valores[1] + "') " +
                                  " AND FORMAT(TIME_STAMP, 'yyyy-MM-dd') <= DATEADD(DAY, 1, '" + valores[1] + "')) " +
                                  " AND(FORMAT(TIME_STAMP, 'HH') >= 0 AND FORMAT(TIME_STAMP, 'HH') < 7) " +
                                  " ORDER BY ID";
                }
                //filtra por dos fechas y por turno
                else if (componente[0] == true && componente[1] == true && componente[2] == true && componente[3] == true)
                {
                    condicion += " AND DEVICE=" + valores[0];
                    if (valores[3] == "A")
                        condicion += " AND  FORMAT(TIME_STAMP, 'yyyy-MM-dd')>= '" + valores[1] + "' AND FORMAT(TIME_STAMP, 'yyyy-MM-dd')<='" + valores[2] + "'" + " AND (FORMAT(TIME_STAMP, 'HH') >= 7 AND FORMAT(TIME_STAMP, 'HH') < 19)";
                    else
                        condicion += " AND (FORMAT(TIME_STAMP, 'yyyy-MM-dd') >= '" + valores[1] + "'" +
                                  " AND FORMAT(TIME_STAMP, 'yyyy-MM-dd') <= '" + valores[2] + "')" +
                                  " AND (FORMAT(TIME_STAMP, 'HH') >= 19 AND FORMAT(TIME_STAMP, 'HH') <= 23) " +
                                " UNION " +
                                " SELECT ID, DIAMETER, DISTANCE, dbo.NO_REFERENCIA(DISTANCE, STATUS) AS STATUS, COUNTER, JOB, IMAGE, INSERTDATE " +
                                " FROM [opc].[dbo].[CONCENTRICITY] " +
                                " WHERE(FORMAT(TIME_STAMP, 'yyyy-MM-dd') >= DATEADD(DAY, 1, '" + valores[1] + "') " +
                                " AND FORMAT(TIME_STAMP, 'yyyy-MM-dd') <= '" + valores[2] + "') " +
                                " AND (FORMAT(TIME_STAMP, 'HH') >= 0 AND FORMAT(TIME_STAMP, 'HH') < 7) " +
                                " ORDER BY ID ";
                }*/
            }

            if (condicion != "") condicion = "WHERE " + condicion.Substring(5);

            string query = @"SELECT S.ID AS CONSECUTIVO, M.maq_numero AS ESTACION, M.maq_lado AS LADO, IFNULL(N.num_numparte, 'COMPONENTE') AS NUMPARTE, 
                             IFNULL(p.proc_proceso, 'NO APLICA') AS PROCESO, S.empleado AS 'NO. EMPLEADO', S.turno AS TURNO, 
                             S.defecto, S.CANTIDAD AS TOTAL, S.fecha, U.usu_nombre   
                             FROM TBLSCRAP S
                             INNER JOIN MAQUINARIA M ON M.MAQ_ID = S.COMP_ID 
                             LEFT JOIN usuariossistema U ON U.usu_id = S.empleado
                             LEFT JOIN numparte N ON N.num_id = S.num_id
                             LEFT JOIN procesos p ON p.proc_id = S.id_pro " + condicion;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }
        }
        public DataTable SelectComponentes(int id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;

            string query = @"SELECT sc.id AS ID, s.id AS 'KEY', s.cantidad AS PIEZAS, s.defecto AS DEFECTO, C.componente AS COMPONENTE, C.description AS DESCRIPCCION, 
                            sc.cantidad CANTIDAD, C.standar_cost AS COSTO
                            FROM tblscrap s
                            INNER JOIN tblscrapcomponentes sc ON sc.consecutivo = s.id
                            INNER JOIN tblcomponentes C ON C.id = sc.id_componente
                            WHERE s.id =?id
                            ORDER BY sc.id";

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("id", id);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                connection.Close();

                return dt;
            }

        }
    }
}
