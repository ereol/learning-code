// See https://aka.ms/new-console-template for more information
DateTime dt = DateTime.UtcNow;
DateTime setTime = new System.DateTime(01,01,01);
string dtUtc = dt.ToString("HH:mm"); 
int Date = Convert.ToInt32(dt.DayOfWeek);
var SystemTime = DateTime.Now.ToString("HH:mm");
string SystemDay = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
string SystemHour = DateTime.UtcNow.ToString("HH:mm");
Console.WriteLine("BDO MENU");
Console.WriteLine("Time now is: " + SystemTime);
Console.WriteLine(TimeTable(Date, dtUtc));


static string TimeTable(int Date, int dtUtc)
{
    int time = -1;
    string Monster = "N/A";
    DateTime first = new DateTime(14,0,0);
    DateTime second = new DateTime(17,0,0);
    DateTime third = new DateTime(21,0,0);
    DateTime fourth = new DateTime(0,0,0);
    DateTime fifth = new DateTime(03,15,0);
    DateTime sixth = new DateTime(04,15,0);
    DateTime seventh = new DateTime(05,15,0);
    DateTime eight = new DateTime(07,0,0);
    DateTime ninth = new DateTime(10,0,0);

    DateTime Results;
    switch(dtUtc)
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
            time = 8;
            Results = dtUtc.Subtract(first);
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
    }

    string output = Console.Write("Next boss is " + Monster.ToString + ".\nIt will appear in {0}", Results);
    return output;

}


