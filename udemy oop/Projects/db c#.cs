namespace ConsoleApp7
{
    internal class Program
    {
        public class DbConnection {
            public string ConnectionString;
            public TimeSpan Timeout { get; set; }
            

            public DbConnection(string cs)
            {
                if (cs == null || cs == "")
                    throw new InvalidOperationException("Error");
                

            }

            public virtual void Open() { }
            public virtual void Close() { }


        }

        public class SqlConnection : DbConnection
        {
            public SqlConnection(string cs) : base(cs)
            {

            }

            public override void Open() {
                Console.WriteLine(" SQL connection openned");
            }
            public override void Close() {
                Console.WriteLine("SQl Connection closed");
            }
        }

        public class OracleConnection : DbConnection
        {
            public OracleConnection(string cs) : base(cs)
            {
            }

            public override void Open()
            {
                Console.WriteLine(" Oracle connection openned");
            }
            public override void Close()
            {
                Console.WriteLine("Oracle Connection closed");
            }
        }



        static void Main(string[] args)
        {
            var sql = new SqlConnection("asdf");
            sql.Open();
            sql.Close();

            var oracle = new OracleConnection("asdf");
            oracle.Open();
            oracle.Close();
        }
    }
}