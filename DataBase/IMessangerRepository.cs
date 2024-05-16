namespace Messanger.DataBase {
    internal interface IMessangerRepository {
        bool OpenConnect();
        bool CloseConnect();
    }
}
