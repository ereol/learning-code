// See https://aka.ms/new-console-template for more information
DateTime dt = DateTime.UtcNow;
int time = 0;
int Date = Convert.ToInt32(dt.DayOfWeek);
var SystemTime = DateTime.Now.ToString("HH:mm");
string SystemDay = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
string SystemHour = DateTime.UtcNow.ToString("HH:mm:ss");
string Monster = "N/A";
Console.WriteLine("BDO MENU");
Console.WriteLine("Time now is: " + Convert.ToString(SystemTime));

switch(SystemTime)
{
        case "14:00":
            time = 0;
            break;
        case "17:00":
            time = 1;
            break;
        case "21:00":
            time = 2;
            break;
        case "00:00":
            time = 3;
            break;
        case "03:15":
            time = 4;
            break;
        case "04:15":
            time = 5;
            break;
        case "05:15":
            time = 6;
            break;
        case "07:00":
            time = 7;
            break;
        case "10:00":
            time = 8;
            break;
        default:
            break;
}

switch(Date)
{
case 0:
    switch(time)
    {
        case 0:
            Monster = "Kutum";
            break;
        case 1:
            Monster = "Nouver";
            break;
        case 2:
            Monster = "Quint/Muraka";
            break;
        case 3:
            Monster = "Kzarka/Karanda";
            break;
        case 4:
            break;
        case 5:
            break;
        case 76:
            Monster = "Nouver/Kutum";
            break;
        case 7:
            Monster = "Kzarka";
            break;
        case 8:
            Monster = "Kutum";
            break;
        default:
            break;
    }
    break;
case 1:
    switch(time)
    {
        case 0:
            Monster = "Nouver";
            break;
        case 1:
            Monster = "Kzarka";
            break;
        case 2:
            Monster = "Veil";
            break;
        case 3:
            Monster = "Garmoth";
            break;
        case 4:
            Monster = "Kzarka/Nouver";
            break;
        case 5:
            break;
        case 6:
            Monster = "Karanda/Kutum";
            break;
        case 7:
            Monster = "Karanda";
            break;
        case 8:
            Monster = "Kzarka";
            break;
        default:
            break;
    }
    break;
case 2:
    switch(time)
    {
        case 0:
            Monster = "Kzarka";
            break;
        case 1:
            Monster = "Offin";
            break;
        case 2:
            Monster = "Kutum";
            break;
        case 3:
            Monster = "Nouver";
            break;
        case 4:
            Monster = "Kzarka";
            break;
        case 5:
            break;
        case 6:
            Monster = "Karanda";
            break;
        case 7:
            Monster = "Kutum";
            break;
        case 8:
            Monster = "Kzarka";
            break;
        default:
            break;
    }
    break;
case 3:
    switch(time)
    {
        case 0:
            Monster = "Nouver";
            break;
        case 1:
            Monster = "Kutum";
            break;
        case 2:
            Monster = "Nouver";
            break;
        case 3:
            Monster = "Karanda";
            break;
        case 4:
            Monster = "Garmoth";
            break;
        case 5:
            break;
        case 6:
            Monster = "Kzarka/Kutum";
            break;
        case 7:
            Monster = "Karanda";
            break;
        case 8:
            Monster = "Maintenance";
            break;
        default:
            break;
    }
    break;
case 4:
    switch(time)
    {
        case 0:
            Monster = "Karanda";
            break;
        case 1:
            Monster = "Nouver";
            break;
        case 2:
            Monster = "Kutum/Offin";
            break;
        case 3:
            Monster = "Vell";
            break;
        case 4:
            Monster = "Kzarka/Karanda";
            break;
        case 5:
            Monster = "Quint/Muraka";
            break;
        case 6:
            Monster = "Nouver";
            break;
        case 7:
            Monster = "Kutum";
            break;
        case 8:
            Monster = "Kzarka";
            break;
        default:
            break;
    }
    break;
case 5:
    switch(time)
    {
        case 0:
            Monster = "Kutum";
            break;
        case 1:
            Monster = "Nouver";
            break;
        case 2:
            Monster = "Kzarka";
            break;
        case 3:
            Monster = "Kutum";
            break;
        case 4:
            Monster = "Garmoth";
            break;
        case 5:
            break;
        case 6:
            Monster = "Karanda/Kzarka";
            break;
        case 7:
            Monster = "Nouver";
            break;
        case 8:
            Monster = "Karanda";
            break;
        default:
            break;
    }
break;
case 6:
    switch(time)
    {
        case 0:
            Monster = "Kutum";
            break;
        case 1:
            Monster = "Karanda";
            break;
        case 2:
            Monster = "Nouver";
            break;
        case 3:
            Monster = "Kzarka";
            break;
        case 4:
            Monster = "Kutum/Kzarka";
            break;
        case 5:
            break;
        case 6:
            Monster = "Karanda";
            break;
        case 7:
            Monster = "Offin";
            break;
        case 8:
            Monster = "Nouver";
            break;
        default:
            break;
    }
break;
}


