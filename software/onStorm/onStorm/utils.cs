using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace onStorm
{
    public class utils
    {
        public static class Folder
        {
            public static string AppDataFolder ()
            {
                var userPath = Environment.GetEnvironmentVariable(
                    RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ?
                    "LOCALAPPDATA" : "Home");

                var assy = System.Reflection.Assembly.GetEntryAssembly();
                var companyName = assy.GetCustomAttributes<AssemblyCompanyAttribute>().FirstOrDefault();
                var path = System.IO.Path.Combine(userPath, companyName.Company);

                return path;
            }
        }

        public static class Obj
        {
            private static string universalDateFormat = "ddMMyyyyHHmmss";
            public static string Nome<T> (Expression<Func<T>> memberExpression)
            {
                MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
                return expressionBody.Member.Name;
            }

            public static string Tipo<T> (T parametros)
            {
                return typeof(T).Name;
            }

            public static string ToStr<T> (T parametro)
            {
                if( typeof(T) == typeof(string) )
                {
                    return parametro.ToString();
                }
                else if( typeof(T) == typeof(int) )
                {
                    return parametro.ToString();
                }
                else if( typeof(T) == typeof(DateTime) )
                {
                    var data = Convert.ToDateTime(parametro);
                    return data.ToString(universalDateFormat);
                }
                else if( typeof(T) == typeof(string) )
                {
                    return parametro.ToString();
                }
                else
                {
                    return parametro.ToString();
                }
            }

            //public static T ToObj<T>(T parametro, string nome, string data)
            //{
            //    //if( typeof(T) == typeof(string) )
            //    //{
            //    //    return parametro = data;
            //    //}
            //    //else if( typeof(T) == typeof(int) )
            //    //{
            //    //    return parametro.ToString();
            //    //}
            //    //else if( typeof(T) == typeof(DateTime) )
            //    //{
            //    //    var data = Convert.ToDateTime(parametro);
            //    //    return data.ToString(universalDateFormat);
            //    //}
            //    //else if( typeof(T) == typeof(string) )
            //    //{
            //    //    return parametro.ToString();
            //    //}
            //    //else
            //    //{
            //    //    return parametro.ToString();
            //    //}
            //}
        }
    }

    public class dataBasic
    {
        public static void incluirDispositivos ()
        {
            List<dispositivoModel> l = new List<dispositivoModel>();

            #region dados
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1392685764",
                nome = "Tokyo Japan JPN",
                local = "35.685_139.7514"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1484247881",
                nome = "Mexico City Mexico MEX",
                local = "19.4424_-99.131"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1050529279",
                nome = "Dhaka Bangladesh BGD",
                local = "23.7231_90.4086"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1032717330",
                nome = "Buenos Aires Argentina ARG",
                local = "-34.6025_-58.3975"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1818253931",
                nome = "Cairo Egypt EGY",
                local = "30.05_31.25"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1156228865",
                nome = "Beijing China CHN",
                local = "39.9289_116.3883"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1608618140",
                nome = "Manila Philippines PHL",
                local = "14.6042_120.9822"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1643318494",
                nome = "Moscow Russia RUS",
                local = "55.7522_37.6155"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1250015082",
                nome = "Paris France FRA",
                local = "48.8667_2.3333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1410836482",
                nome = "Seoul Korea. South KOR",
                local = "37.5663_126.9997"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1360771077",
                nome = "Jakarta Indonesia IDN",
                local = "-6.1744_106.8294"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1826645935",
                nome = "London United Kingdom GBR",
                local = "51.5_-0.1167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1604728603",
                nome = "Lima Peru PER",
                local = "-12.048_-77.0501"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1364305026",
                nome = "Tehran Iran IRN",
                local = "35.6719_51.4243"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1180000363",
                nome = "Kinshasa Congo (Kinshasa) COD",
                local = "-4.3297_15.315"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1170483426",
                nome = "Bogotá Colombia COL",
                local = "4.5964_-74.0833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1158881289",
                nome = "Taipei Taiwan TWN",
                local = "25.0358_121.5683"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1764068610",
                nome = "Bangkok Thailand THA",
                local = "13.75_100.5166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1152554349",
                nome = "Santiago Chile CHL",
                local = "-33.45_-70.667"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1724616994",
                nome = "Madrid Spain ESP",
                local = "40.4_-3.6834"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1840006060",
                nome = "Washington United States USA",
                local = "38.9047_-77.0163"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1702341327",
                nome = "Singapore Singapore SGP",
                local = "1.293_103.8558"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1024949724",
                nome = "Luanda Angola AGO",
                local = "-8.8383_13.2344"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1368596238",
                nome = "Baghdad Iraq IRQ",
                local = "33.3386_44.3939"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1729268475",
                nome = "Khartoum Sudan SDN",
                local = "15.5881_32.5342"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1682999334",
                nome = "Riyadh Saudi Arabia SAU",
                local = "24.6408_46.7727"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1704413791",
                nome = "Hanoi Vietnam VNM",
                local = "21.0333_105.85"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1104616656",
                nome = "Rangoon Burma MMR",
                local = "16.7834_96.1667"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1384207980",
                nome = "Abidjan Côte D’Ivoire CIV",
                local = "5.32_-4.04"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1076144436",
                nome = "Brasília Brazil BRA",
                local = "-15.7833_-47.9161"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1792572891",
                nome = "Ankara Turkey TUR",
                local = "39.9272_32.8644"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1276451290",
                nome = "Berlin Germany DEU",
                local = "52.5218_13.4015"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1012973369",
                nome = "Algiers Algeria DZA",
                local = "36.7631_3.0506"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1380382862",
                nome = "Rome Italy ITA",
                local = "41.896_12.4833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1408738594",
                nome = "Pyongyang Korea. North PRK",
                local = "39.0194_125.7547"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1004993580",
                nome = "Kabul Afghanistan AFG",
                local = "34.5167_69.1833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1300715560",
                nome = "Athens Greece GRC",
                local = "37.9833_23.7333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1710680650",
                nome = "Cape Town South Africa ZAF",
                local = "-33.92_18.435"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1231824991",
                nome = "Addis Ababa Ethiopia ETH",
                local = "9.0333_38.7"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1404000661",
                nome = "Nairobi Kenya KEN",
                local = "-1.2833_36.8167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1862748204",
                nome = "Caracas Venezuela VEN",
                local = "10.501_-66.917"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1834843853",
                nome = "Dar es Salaam Tanzania TZA",
                local = "-6.8_39.2683"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1620619017",
                nome = "Lisbon Portugal PRT",
                local = "38.7227_-9.1449"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1804382913",
                nome = "Kyiv Ukraine UKR",
                local = "50.4334_30.5166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1686604760",
                nome = "Dakar Senegal SEN",
                local = "14.7158_-17.4731"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1760685964",
                nome = "Damascus Syria SYR",
                local = "33.5_36.3"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1788742103",
                nome = "Tunis Tunisia TUN",
                local = "36.8028_10.1797"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1040261752",
                nome = "Vienna Austria AUT",
                local = "48.2_16.3666"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1434201852",
                nome = "Tripoli Libya LBY",
                local = "32.8925_13.18"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1860331871",
                nome = "Tashkent Uzbekistan UZB",
                local = "41.3117_69.2949"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1192752771",
                nome = "Havana Cuba CUB",
                local = "23.132_-82.3642"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1214636202",
                nome = "Santo Domingo Dominican Republic DOM",
                local = "18.4701_-69.9001"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1031946365",
                nome = "Baku Azerbaijan AZE",
                local = "40.3953_49.8622"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1288299415",
                nome = "Accra Ghana GHA",
                local = "5.55_-0.2167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1414102075",
                nome = "Kuwait City Kuwait KWT",
                local = "29.3697_47.9783"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1887750814",
                nome = "Sanaa Yemen YEM",
                local = "15.3547_44.2066"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1332401940",
                nome = "Port-au-Prince Haiti HTI",
                local = "18.541_-72.336"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1642414442",
                nome = "Bucharest Romania ROU",
                local = "44.4334_26.0999"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1600057911",
                nome = "Asunción Paraguay PRY",
                local = "-25.2964_-57.6415"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1422847713",
                nome = "Beirut Lebanon LBN",
                local = "33.872_35.5097"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1112348503",
                nome = "Minsk Belarus BLR",
                local = "53.9_27.5666"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1056469830",
                nome = "Brussels Belgium BEL",
                local = "50.8333_4.3333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1616024847",
                nome = "Warsaw Poland POL",
                local = "52.25_21"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1504023252",
                nome = "Rabat Morocco MAR",
                local = "34.0253_-6.8361"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1218441993",
                nome = "Quito Ecuador ECU",
                local = "-0.215_-78.5001"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1450978461",
                nome = "Antananarivo Madagascar MDG",
                local = "-18.9166_47.5166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1348611435",
                nome = "Budapest Hungary HUN",
                local = "47.5_19.0833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1120298240",
                nome = "Yaoundé Cameroon CMR",
                local = "3.8667_11.5167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1068000064",
                nome = "La Paz Bolivia BOL",
                local = "-16.498_-68.15"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1566342270",
                nome = "Abuja Nigeria NGA",
                local = "9.0833_7.5333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1716196799",
                nome = "Harare Zimbabwe ZWE",
                local = "-17.8178_31.0447"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1858107000",
                nome = "Montevideo Uruguay URY",
                local = "-34.858_-56.1711"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1466965925",
                nome = "Bamako Mali MLI",
                local = "12.65_-8"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1324568159",
                nome = "Conakry Guinea GIN",
                local = "9.5315_-13.6802"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1116260534",
                nome = "Phnom Penh Cambodia KHM",
                local = "11.55_104.9166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1768409132",
                nome = "Lomé Togo TGO",
                local = "6.1319_1.2228"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1634459660",
                nome = "Doha Qatar QAT",
                local = "25.2866_51.533"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1458988644",
                nome = "Kuala Lumpur Malaysia MYS",
                local = "3.1667_101.7"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1508074843",
                nome = "Maputo Mozambique MOZ",
                local = "-25.9553_32.5892"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1222647454",
                nome = "San Salvador El Salvador SLV",
                local = "13.71_-89.203"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1800406299",
                nome = "Kampala Uganda UGA",
                local = "0.3167_32.5833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1528799905",
                nome = "The Hague Netherlands NLD",
                local = "52.08_4.27"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1178340306",
                nome = "Brazzaville Congo (Brazzaville) COG",
                local = "-4.2592_15.2847"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1710176249",
                nome = "Pretoria South Africa ZAF",
                local = "-25.7069_28.2294"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1894157390",
                nome = "Lusaka Zambia ZMB",
                local = "-15.4166_28.2833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1188749877",
                nome = "San José Costa Rica CRI",
                local = "9.935_-84.0841"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1591672475",
                nome = "Panama City Panama PAN",
                local = "8.968_-79.533"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1752425602",
                nome = "Stockholm Sweden SWE",
                local = "59.3508_18.0973"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1100762037",
                nome = "Sofia Bulgaria BGR",
                local = "42.6833_23.3167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1203744823",
                nome = "Prague Czechia CZE",
                local = "50.0833_14.466"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1854029208",
                nome = "Ouagadougou Burkina Faso BFA",
                local = "12.3703_-1.5247"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1124399363",
                nome = "Ottawa Canada CAN",
                local = "45.4167_-75.7"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1246177997",
                nome = "Helsinki Finland FIN",
                local = "60.1756_24.9341"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1051074169",
                nome = "Yerevan Armenia ARM",
                local = "40.1812_44.5136"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1706893395",
                nome = "Mogadishu Somalia SOM",
                local = "2.0667_45.3667"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1268203191",
                nome = "Tbilisi Georgia GEO",
                local = "41.725_44.7908"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1688374696",
                nome = "Belgrade Serbia SRB",
                local = "44.8186_20.468"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1762930616",
                nome = "Dushanbe Tajikistan TJK",
                local = "38.56_68.7739"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1208763942",
                nome = "Copenhagen Denmark DNK",
                local = "55.6786_12.5635"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1400522593",
                nome = "Amman Jordan JOR",
                local = "31.95_35.9333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1372595407",
                nome = "Dublin Ireland IRL",
                local = "53.3331_-6.2489"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1430477826",
                nome = "Monrovia Liberia LBR",
                local = "6.3106_-10.8048"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1528355309",
                nome = "Amsterdam Netherlands NLD",
                local = "52.35_4.9166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1376261644",
                nome = "Jerusalem Israel ISR",
                local = "31.7784_35.2066"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1320197916",
                nome = "Guatemala City Guatemala GTM",
                local = "14.6211_-90.527"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1148708596",
                nome = "N’Djamena Chad TCD",
                local = "12.1131_15.0491"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1340344059",
                nome = "Tegucigalpa Honduras HND",
                local = "14.102_-87.2175"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1388709177",
                nome = "Kingston Jamaica JAM",
                local = "17.9771_-76.7674"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1104838105",
                nome = "Nay Pyi Taw Burma MMR",
                local = "19.7666_96.1186"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1262028958",
                nome = "Djibouti Djibouti DJI",
                local = "11.595_43.148"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1558296252",
                nome = "Managua Nicaragua NIC",
                local = "12.153_-86.2685"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1562932886",
                nome = "Niamey Niger NER",
                local = "13.5167_2.1167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1008162156",
                nome = "Tirana Albania ALB",
                local = "41.3275_19.8189"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1524589448",
                nome = "Kathmandu Nepal NPL",
                local = "27.7167_85.3166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1496024767",
                nome = "Ulaanbaatar Mongolia MNG",
                local = "47.9167_106.9166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1646923541",
                nome = "Kigali Rwanda RWA",
                local = "-1.9536_30.0605"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1417191971",
                nome = "Bishkek Kyrgyzstan KGZ",
                local = "42.8731_74.5852"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1578324706",
                nome = "Oslo Norway NOR",
                local = "59.9167_10.75"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1140080881",
                nome = "Bangui Central African Republic CAF",
                local = "4.3666_18.5583"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1694085071",
                nome = "Freetown Sierra Leone SLE",
                local = "8.47_-13.2342"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1586306717",
                nome = "Islamabad Pakistan PAK",
                local = "33.7_73.1666"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1204955174",
                nome = "Cotonou Benin BEN",
                local = "6.4_2.52"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1418732714",
                nome = "Vientiane Laos LAO",
                local = "17.9667_102.6"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1428586192",
                nome = "Riga Latvia LVA",
                local = "56.95_24.1"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1478414984",
                nome = "Nouakchott Mauritania MRT",
                local = "18.0864_-15.9753"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1512035506",
                nome = "Muscat Oman OMN",
                local = "23.6133_58.5933"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1795049992",
                nome = "Ashgabat Turkmenistan TKM",
                local = "37.95_58.3833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1191233290",
                nome = "Zagreb Croatia HRV",
                local = "45.8_16"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1070966777",
                nome = "Sarajevo Bosnia And Herzegovina BIH",
                local = "43.85_18.383"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1498011437",
                nome = "Chisinau Moldova MDA",
                local = "47.005_28.8577"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1454688499",
                nome = "Lilongwe Malawi MWI",
                local = "-13.9833_33.7833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1232791236",
                nome = "Asmara Eritrea ERI",
                local = "15.3333_38.9333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1784176710",
                nome = "Abu Dhabi United Arab Emirates ARE",
                local = "24.4667_54.3666"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1480131261",
                nome = "Port Louis Mauritius MUS",
                local = "-20.1666_57.5"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1266952885",
                nome = "Libreville Gabon GAB",
                local = "0.3854_9.458"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1048989486",
                nome = "Manama Bahrain BHR",
                local = "26.2361_50.5831"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1440887149",
                nome = "Vilnius Lithuania LTU",
                local = "54.6834_25.3166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1807600615",
                nome = "Skopje Macedonia MKD",
                local = "42_21.4335"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1710495933",
                nome = "Bloemfontein South Africa ZAF",
                local = "-29.12_26.2299"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1703195001",
                nome = "Bratislava Slovakia SVK",
                local = "48.15_17.117"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1624168850",
                nome = "Bissau Guinea-Bissau GNB",
                local = "11.865_-15.5984"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1233260021",
                nome = "Tallinn Estonia EST",
                local = "59.4339_24.728"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1554772152",
                nome = "Wellington New Zealand NZL",
                local = "-41.3_174.7833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1470574399",
                nome = "Valletta Malta MLT",
                local = "35.8997_14.5147"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1426977668",
                nome = "Maseru Lesotho LSO",
                local = "-29.3167_27.4833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1398516045",
                nome = "Nur-Sultan Kazakhstan KAZ",
                local = "51.1811_71.4278"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1108101689",
                nome = "Bujumbura Burundi BDI",
                local = "-3.3761_29.36"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1036142029",
                nome = "Canberra Australia AUS",
                local = "-35.283_149.129"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1356215164",
                nome = "New Delhi India IND",
                local = "28.6_77.2"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1705917455",
                nome = "Ljubljana Slovenia SVN",
                local = "46.0553_14.515"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1204172060",
                nome = "Porto-Novo Benin BEN",
                local = "6.4833_2.6166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1096465895",
                nome = "Bandar Seri Begawan Brunei BRN",
                local = "4.8833_114.9333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1780670676",
                nome = "Port of Spain Trinidad And Tobago TTO",
                local = "10.652_-61.517"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1598685395",
                nome = "Port Moresby Papua New Guinea PNG",
                local = "-9.4647_147.1925"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1756374318",
                nome = "Bern Switzerland CHE",
                local = "46.9167_7.467"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1516802003",
                nome = "Windhoek Namibia NAM",
                local = "-22.57_17.0835"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1328160906",
                nome = "Georgetown Guyana GUY",
                local = "6.802_-58.167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1740518660",
                nome = "Paramaribo Suriname SUR",
                local = "5.835_-55.167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1626308942",
                nome = "Dili Timor-Leste TLS",
                local = "-8.5594_125.5795"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1044318561",
                nome = "Nassau Bahamas. The BHS",
                local = "25.0834_-77.35"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1068823873",
                nome = "Sucre Bolivia BOL",
                local = "-19.041_-65.2595"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1196944155",
                nome = "Nicosia Cyprus CYP",
                local = "35.1667_33.3666"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1834288497",
                nome = "Dodoma Tanzania TZA",
                local = "-6.1833_35.75"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1144251314",
                nome = "Colombo Sri Lanka LKA",
                local = "6.932_79.8578"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1072756768",
                nome = "Gaborone Botswana BWA",
                local = "-24.6463_25.9119"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1384683557",
                nome = "Yamoussoukro Côte D’Ivoire CIV",
                local = "6.8184_-5.2755"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1052274244",
                nome = "Bridgetown Barbados BRB",
                local = "13.102_-59.6165"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1242615095",
                nome = "Suva Fiji FJI",
                local = "-18.133_178.4417"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1352327190",
                nome = "Reykjavík Iceland ISL",
                local = "64.15_-21.95"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1226861333",
                nome = "Malabo Equatorial Guinea GNQ",
                local = "3.75_8.7833"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1531000000",
                nome = "Willemstad Curaçao CUW",
                local = "12.2004_-69.02"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1499454516",
                nome = "Podgorica Montenegro MNE",
                local = "42.466_19.2663"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1174793581",
                nome = "Moroni Comoros COM",
                local = "-11.7042_43.2402"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1144239330",
                nome = "Sri Jayewardenepura Kotte Sri Lanka LKA",
                local = "6.9_79.95"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1132398770",
                nome = "Praia Cabo Verde CPV",
                local = "14.9167_-23.5167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1462441685",
                nome = "Male Maldives MDV",
                local = "4.1667_73.4999"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1728444337",
                nome = "Juba South Sudan SSD",
                local = "4.83_31.58"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1442262731",
                nome = "Luxembourg Luxembourg LUX",
                local = "49.6117_6.13"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1064010361",
                nome = "Thimphu Bhutan BTN",
                local = "27.473_89.639"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1748811945",
                nome = "Mbabane Swaziland SWZ",
                local = "-26.3167_31.1333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1678301324",
                nome = "São Tomé Sao Tome And Principe STP",
                local = "0.3334_6.7333"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1090737486",
                nome = "Honiara Solomon Islands SLB",
                local = "-9.438_159.9498"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1533513057",
                nome = "Oranjestad Aruba ABW",
                local = "12.5304_-70.029"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1882489296",
                nome = "Apia Samoa WSM",
                local = "-13.8415_-171.7386"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1020828846",
                nome = "Andorra la Vella Andorra AND",
                local = "42.5_1.5165"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1670376659",
                nome = "Kingstown Saint Vincent And The Grenadines VCT",
                local = "13.1483_-61.2121"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1548805075",
                nome = "Port-Vila Vanuatu VUT",
                local = "-17.7334_168.3166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1270723713",
                nome = "Banjul Gambia. The GMB",
                local = "13.4539_-16.5917"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1776737461",
                nome = "Nuku‘alofa Tonga TON",
                local = "-21.1385_-175.2206"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1662922505",
                nome = "Castries Saint Lucia LCA",
                local = "14.002_-61"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1492854256",
                nome = "Monaco Monaco MCO",
                local = "43.7396_7.4069"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1438317747",
                nome = "Vaduz Liechtenstein LIE",
                local = "47.1337_9.5167"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1028912067",
                nome = "Saint John’s Antigua And Barbuda ATG",
                local = "17.118_-61.85"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1308891766",
                nome = "Saint George’s Grenada GRD",
                local = "12.0526_-61.7416"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1690193579",
                nome = "Victoria Seychelles SYC",
                local = "-4.6166_55.45"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1674741947",
                nome = "San Marino San Marino SMR",
                local = "43.9172_12.4667"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1296152641",
                nome = "Tarawa Kiribati KIR",
                local = "1.3382_173.0176"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1584000000",
                nome = "Majuro Marshall Islands MHL",
                local = "7.103_171.38"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1212060440",
                nome = "Roseau Dominica DMA",
                local = "15.301_-61.387"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1659198919",
                nome = "Basseterre Saint Kitts And Nevis KNA",
                local = "17.302_-62.717"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1084586375",
                nome = "Belmopan Belize BLZ",
                local = "17.252_-88.7671"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1016976740",
                nome = "Pago Pago American Samoa ASM",
                local = "-14.274_-170.7046"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1748963140",
                nome = "Lobamba Swaziland SWZ",
                local = "-26.4667_31.2"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1798251391",
                nome = "Funafuti Tuvalu TUV",
                local = "-8.5167_179.2166"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1583008885",
                nome = "Palikir Micronesia. Federated States Of FSM",
                local = "6.9166_158.15"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1580556972",
                nome = "Capitol Hill Northern Mariana Islands MNP",
                local = "15.2137_145.7546"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1316937540",
                nome = "Hagåtña Guam GUM",
                local = "13.4745_144.7504"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1934000006",
                nome = "Al Quds West Bank XWB",
                local = "31.7764_35.2269"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1534859858",
                nome = "Philipsburg Sint Maarten SXM",
                local = "18.0255_-63.045"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1108778000",
                nome = "Gitega Burundi BDI",
                local = "-3.4271_29.9246"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1901760068",
                nome = "Pristina Kosovo XKS",
                local = "42.6666_21.1724"
            });
            //---------
            l.Add(new dispositivoModel()
            {
                idDisp = "1585525081",
                nome = "Ngerulmud Palau PLW",
                local = "7.5_134.6242"
            });

            // Brasil
            l.Add(new dispositivoModel() { idDisp = "1076532519", nome = "São Paulo Brazil BRA", local = "-23.5587_-46.625" });
            l.Add(new dispositivoModel() { idDisp = "1076887657", nome = "Rio de Janeiro Brazil BRA", local = "-22.925_-43.225" });
            l.Add(new dispositivoModel() { idDisp = "1076967355", nome = "Belo Horizonte Brazil BRA", local = "-19.915_-43.915" });
            l.Add(new dispositivoModel() { idDisp = "1076658221", nome = "Porto Alegre Brazil BRA", local = "-30.05_-51.2" });
            l.Add(new dispositivoModel() { idDisp = "1076137337", nome = "Recife Brazil BRA", local = "-8.0756_-34.9156" });
            l.Add(new dispositivoModel() { idDisp = "1076567885", nome = "Fortaleza Brazil BRA", local = "-3.75_-38.58" });
            l.Add(new dispositivoModel() { idDisp = "1076923789", nome = "Salvador Brazil BRA", local = "-12.97_-38.48" });
            l.Add(new dispositivoModel() { idDisp = "1076701712", nome = "Curitiba Brazil BRA", local = "-25.42_-49.32" });
            l.Add(new dispositivoModel() { idDisp = "1076646823", nome = "Belém Brazil BRA", local = "-1.45_-48.48" });
            l.Add(new dispositivoModel() { idDisp = "1076034054", nome = "Goiânia Brazil BRA", local = "-16.72_-49.3" });
            l.Add(new dispositivoModel() { idDisp = "1076607274", nome = "Manaus Brazil BRA", local = "-3.1_-60" });
            l.Add(new dispositivoModel() { idDisp = "1076376829", nome = "Vitória Brazil BRA", local = "-20.324_-40.366" });
            l.Add(new dispositivoModel() { idDisp = "1076440479", nome = "Maceió Brazil BRA", local = "-9.62_-35.73" });
            l.Add(new dispositivoModel() { idDisp = "1076697777", nome = "Natal Brazil BRA", local = "-5.78_-35.24" });
            l.Add(new dispositivoModel() { idDisp = "1076819308", nome = "São Luís Brazil BRA", local = "-2.516_-44.266" });
            l.Add(new dispositivoModel() { idDisp = "1076190259", nome = "Florianópolis Brazil BRA", local = "-27.58_-48.52" });
            l.Add(new dispositivoModel() { idDisp = "1076922014", nome = "João Pessoa Brazil BRA", local = "-7.1011_-34.8761" });
            l.Add(new dispositivoModel() { idDisp = "1076727667", nome = "Teresina Brazil BRA", local = "-5.095_-42.78" });
            l.Add(new dispositivoModel() { idDisp = "1076112309", nome = "Cuiabá Brazil BRA", local = "-15.5696_-56.085" });
            l.Add(new dispositivoModel() { idDisp = "1076660445", nome = "Campo Grande Brazil BRA", local = "-20.45_-54.6166" });
            l.Add(new dispositivoModel() { idDisp = "1076527830", nome = "Aracaju Brazil BRA", local = "-10.9_-37.12" });
            l.Add(new dispositivoModel() { idDisp = "1076189884", nome = "Macapá Brazil BRA", local = "0.033_-51.05" });
            l.Add(new dispositivoModel() { idDisp = "1076045591", nome = "Porto Velho Brazil BRA", local = "-8.75_-63.9" });
            l.Add(new dispositivoModel() { idDisp = "1076391263", nome = "Rio Branco Brazil BRA", local = "-9.9666_-67.8" });
            l.Add(new dispositivoModel() { idDisp = "1076052802", nome = "Palmas Brazil BRA", local = "-10.2377_-48.2878" });
            l.Add(new dispositivoModel() { idDisp = "1076621300", nome = "Boa Vista Brazil BRA", local = "2.8161_-60.666" });
            l.Add(new dispositivoModel() { idDisp = "1076144436", nome = "Brasília Brazil BRA", local = "-15.7833_-47.9161" });


            #endregion

            var banco = new Banco();
            foreach( var d in l )
            {
                banco.incluirDispositivo(d);
                Random r = new Random();
                List<registroModel> j = new List<registroModel>();

                var re = new registroModel()
                {
                    data = DateTime.Now.AddDays(-1),
                    chuva = r.Next(0, 1023),
                    temperatura = r.Next(0, 1023),
                    idDisp = d.idDisp,
                };

                for( int i = 0; i < 20; i++ )
                {
                    j.Add(new registroModel()
                    {
                        data = DateTime.Now.AddDays(-i),
                        chuva = re.chuva,
                        temperatura = re.temperatura,
                        idDisp = d.idDisp,
                    });
                }

                banco.incluirRegistro(j);
            }

        }
    }
}
