// Абстрактный продукт A,B устройства
abstract class Device
{
    public abstract string GetOS();
    public abstract string GetModel();
}

// Конкретные продукты
class Phone : Device
{
    public override string GetOS()
    {
        return "Не определено";
    }

    public override string GetModel()
    {
        return "Не определено";
    }
}

class AndroidPhone : Phone
{
    public override string GetOS()
    {
        return "Android";
    }

    public override string GetModel()
    {
        return "Android Phone";
    }
}

class IOSPhone : Phone
{
    public override string GetOS()
    {
        return "iOS";
    }

    public override string GetModel()
    {
        return "iPhone";
    }
}

class Tablet : Device
{
    public override string GetOS()
    {
        return "Не определено";
    }

    public override string GetModel()
    {
        return "Не определено";
    }
}

class AndroidTablet : Tablet
{
    public override string GetOS()
    {
        return "Android";
    }

    public override string GetModel()
    {
        return "Android Tablet";
    }
}

class IOSTablet : Tablet
{
    public override string GetOS()
    {
        return "iOS";
    }

    public override string GetModel()
    {
        return "iPad";
    }
}

// Абстрактная фабрика 
abstract class IDeviceFactory
{
    public abstract Phone CreatePhone();
    public abstract Tablet CreateTablet();
}

// Конкретные фабрики 
class AndroidFactory : IDeviceFactory
{
    public override Phone CreatePhone()
    {
        return new AndroidPhone();
    }

    public override Tablet CreateTablet()
    {
        return new AndroidTablet();
    }
}

class IOSFactory : IDeviceFactory
{
    public override Phone CreatePhone()
    {
        return new IOSPhone();
    }

    public override Tablet CreateTablet()
    {
        return new IOSTablet();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IDeviceFactory androidFactory = new AndroidFactory();
        Phone androidPhone = androidFactory.CreatePhone();
        Console.WriteLine("Операционная система: " + androidPhone.GetOS());
        Console.WriteLine("Модель телефона: " + androidPhone.GetModel());

       IDeviceFactory iosFactory = new IOSFactory();
        Phone iosPhone = iosFactory.CreatePhone();
        Console.WriteLine("Операционная система: " + iosPhone.GetOS());
        Console.WriteLine("Модель телефона: " + iosPhone.GetModel());

        Tablet androidTablet = androidFactory.CreateTablet();
        Console.WriteLine("Операционная система: " + androidTablet.GetOS());
        Console.WriteLine("Модель планшета: " + androidTablet.GetModel());

        Tablet iosTablet = iosFactory.CreateTablet();
        Console.WriteLine("Операционная система: " + iosTablet.GetOS());
        Console.WriteLine("Модель планшета: " + iosTablet.GetModel());

        Console.ReadLine();
    }
}
