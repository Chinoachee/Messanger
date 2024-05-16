namespace Messanger.DataBase {
    internal interface IMessangerRepository {
        abstract bool OpenConnect();
        abstract bool CloseConnect();
    }
}
