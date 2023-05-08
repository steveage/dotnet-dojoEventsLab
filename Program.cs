Order order = new Order();
Email email = new Email();
SMS sms = new SMS();

order.OnCreated += email.Send;
order.OnCreated += sms.Send;

order.Create();