using Bridge;

class Program
{
    static void Main(string[] args)
    {
        
        Notification notify = new Email(new Html_notification());
        notify.Send();
        notify.Notificatiob_is_sended();
        notify.Type  = new Text_notification();
        notify.Send();
        notify.Notificatiob_is_sended();

        Console.Read();
    }
}
