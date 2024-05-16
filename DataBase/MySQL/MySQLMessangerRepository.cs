namespace Messanger.DataBase.MySQL {
    internal class MySQLMessangerRepository : IMessangerRepository {
        private string _connectionString = "server=localhost;user id=root;password=d89-kQV-SW6-KLb;database=messanger";

        public bool CloseConnect() {
            try {

            }
        }

        public bool OpenConnect() {
            throw new NotImplementedException();
        }
    }
}
