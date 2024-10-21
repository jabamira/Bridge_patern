namespace Bridge
{
    class Email : Notification
    {
        public Email(Itype_Notification type) : base(type)
        {
        }
        public override void Notificatiob_is_sended()
        {

            Console.WriteLine("Email is sended");
            Console.WriteLine("/////////////////");
        }
    }
}
