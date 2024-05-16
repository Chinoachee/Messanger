using Messanger.Model.User;

namespace Messanger.DataBase {
    internal interface IMessangerRepository {
        bool OpenConnect();
        bool CloseConnect();
        void AddUser(User user);
        void RemoveUser(User user);
        void UpdateUser(User user);
        User GetUser(string login,string password);
    }
}
