using Q400Calculator.Models;
using System;
using System.Linq;

namespace Q400Calculator.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.ClimbData.Any())
            {
                return;   // DB has been seeded
            }

            var climbtable = new ClimbData[]
            {
            new ClimbData { Weight = 22000, Vfri5 = 116, Vfri10 = 110, Vfri15 = 107, Vclmb = 130 },
            new ClimbData { Weight = 20000, Vfri5 = 120, Vfri10 = 112, Vfri15 = 109, Vclmb = 131 },
            new ClimbData { Weight = 22000, Vfri5 = 126, Vfri10 = 122, Vfri15 = 115, Vclmb = 137 },
            new ClimbData { Weight = 24000, Vfri5 = 132, Vfri10 = 123, Vfri15 = 120, Vclmb = 143 },
            new ClimbData { Weight = 26000, Vfri5 = 137, Vfri10 = 128, Vfri15 = 125, Vclmb = 148 },
            new ClimbData { Weight = 28000, Vfri5 = 142, Vfri10 = 134, Vfri15 = 130, Vclmb = 154 },
            new ClimbData { Weight = 29000, Vfri5 = 146, Vfri10 = 137, Vfri15 = 133, Vclmb = 158 }
            };

            foreach (ClimbData cd in climbtable)
            {
                context.ClimbData.Add(cd);
            }
            context.SaveChanges();

            var flaps518Cold = new flaps518ColdData[]
            {
            new flaps518ColdData{Altitude = 0, Vr = 102, V2 = 116},
            new flaps518ColdData{Altitude = 2000, Vr = 102, V2 = 115},
            new flaps518ColdData{Altitude = 4000, Vr = 102, V2 = 114},
            new flaps518ColdData{Altitude = 6000, Vr = 102, V2 = 113},
            new flaps518ColdData{Altitude = 8000, Vr = 102, V2 = 112},
            new flaps518ColdData{Altitude = 10000, Vr = 103, V2 = 111}
            };
            foreach (flaps518ColdData fcd in flaps518Cold)
            {
                context.flaps518ColdData.Add(fcd);
            }
            context.SaveChanges();


            var flaps520Cold = new flaps520ColdData[]
            {
            new flaps520ColdData{Altitude = 0, Vr = 105, V2 = 115},
            new flaps520ColdData{Altitude = 2000, Vr = 106, V2 = 114},
            new flaps520ColdData{Altitude = 4000, Vr = 107, V2 = 113},
            new flaps520ColdData{Altitude = 6000, Vr = 107, V2 = 112},
            new flaps520ColdData{Altitude = 8000, Vr = 108, V2 = 112},
            new flaps520ColdData{Altitude = 10000, Vr = 110, V2 = 111}
            };
            foreach (flaps520ColdData fcd in flaps520Cold)
            {
                context.flaps520ColdData.Add(fcd);
            }
            context.SaveChanges();


            var flaps522Cold = new flaps522ColdData[]
                {
            new flaps522ColdData{Altitude = 0, Vr = 112, V2 = 117},
            new flaps522ColdData{Altitude = 2000, Vr = 113, V2 = 117},
            new flaps522ColdData{Altitude = 4000, Vr = 113, V2 = 117},
            new flaps522ColdData{Altitude = 6000, Vr = 1114, V2 = 117},
            new flaps522ColdData{Altitude = 8000, Vr = 115, V2 = 117},
            new flaps522ColdData{Altitude = 10000, Vr = 116, V2 = 171}
                };
            foreach (flaps522ColdData fcd in flaps522Cold)
            {
                context.flaps522ColdData.Add(fcd);
            }
            context.SaveChanges();


            var flaps524Cold = new flaps524ColdData[]
            {
            new flaps524ColdData{Altitude = 0, Vr = 122, V2 = 115},
            new flaps524ColdData{Altitude = 2000, Vr = 119, V2 = 114},
            new flaps524ColdData{Altitude = 4000, Vr = 120, V2 = 113},
            new flaps524ColdData{Altitude = 6000, Vr = 120, V2 = 112},
            new flaps524ColdData{Altitude = 8000, Vr = 121, V2 = 112},
            new flaps524ColdData{Altitude = 10000, Vr = 122, V2 = 111}
            };
            foreach (flaps524ColdData fcd in flaps524Cold)
            {
                context.flaps524ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps526Cold = new flaps526ColdData[]
            {
            new flaps526ColdData{Altitude = 0, Vr = 124, V2 = 127},
            new flaps526ColdData{Altitude = 2000, Vr = 125, V2 = 127},
            new flaps526ColdData{Altitude = 4000, Vr = 126, V2 = 127},
            new flaps526ColdData{Altitude = 6000, Vr = 126, V2 = 127},
            new flaps526ColdData{Altitude = 8000, Vr = 127, V2 = 127},
            new flaps526ColdData{Altitude = 10000, Vr = 128, V2 = 127}
            };
            foreach (flaps526ColdData fcd in flaps526Cold)
            {
                context.flaps526ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps528Cold = new flaps528ColdData[]
            {
            new flaps528ColdData{Altitude = 0, Vr = 130, V2 = 1132},
            new flaps528ColdData{Altitude = 2000, Vr = 131, V2 = 132},
            new flaps528ColdData{Altitude = 4000, Vr = 131, V2 = 132},
            new flaps528ColdData{Altitude = 6000, Vr = 132, V2 = 132},
            new flaps528ColdData{Altitude = 8000, Vr = 133, V2 = 132},
            new flaps528ColdData{Altitude = 10000, Vr = 134, V2 = 132}
            };
            foreach (flaps528ColdData fcd in flaps528Cold)
            {
                context.flaps528ColdData.Add(fcd);
            }
            context.SaveChanges();


            var flaps529Cold = new flaps529ColdData[]
            {
            new flaps529ColdData{Altitude = 0, Vr = 133, V2 = 135},
            new flaps529ColdData{Altitude = 2000, Vr = 134, V2 = 135},
            new flaps529ColdData{Altitude = 4000, Vr = 135, V2 = 135},
            new flaps529ColdData{Altitude = 6000, Vr = 136, V2 = 135},
            new flaps529ColdData{Altitude = 8000, Vr = 137, V2 = 135},
            new flaps529ColdData{Altitude = 10000, Vr = 138, V2 = 135}
            };
            foreach (flaps529ColdData fcd in flaps529Cold)
            {
                context.flaps529ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps518Hot = new flaps518HotData[]
            {
            new flaps518HotData{Altitude = 0, Vr = 102, V2 = 114},
            new flaps518HotData{Altitude = 2000, Vr = 102, V2 = 113},
            new flaps518HotData{Altitude = 4000, Vr = 102, V2 = 112},
            new flaps518HotData{Altitude = 6000, Vr = 103, V2 = 111},
            new flaps518HotData{Altitude = 8000, Vr = 103, V2 = 110},
            new flaps518HotData{Altitude = 10000, Vr = 105, V2 = 109}
            };
            foreach (flaps518HotData fhd in flaps518Hot)
            {
                context.flaps518HotData.Add(fhd);
            }
            context.SaveChanges();

            var flaps520Hot = new flaps520HotData[]
            {
            new flaps520HotData{Altitude = 0, Vr = 107, V2 = 113},
            new flaps520HotData{Altitude = 2000, Vr = 108, V2 = 112},
            new flaps520HotData{Altitude = 4000, Vr = 108, V2 = 112},
            new flaps520HotData{Altitude = 6000, Vr = 110, V2 = 111},
            new flaps520HotData{Altitude = 8000, Vr = 110, V2 = 111},
            new flaps520HotData{Altitude = 10000, Vr = 112, V2 = 111}
            };
            foreach (flaps520HotData fhd in flaps520Hot)
            {
                context.flaps520HotData.Add(fhd);
            }
            context.SaveChanges();

            var flaps522Hot = new flaps522HotData[]
{
            new flaps522HotData{Altitude = 0, Vr = 113, V2 = 117},
            new flaps522HotData{Altitude = 2000, Vr = 114, V2 = 117},
            new flaps522HotData{Altitude = 4000, Vr = 115, V2 = 117},
            new flaps522HotData{Altitude = 6000, Vr = 116, V2 = 117},
            new flaps522HotData{Altitude = 8000, Vr = 117, V2 = 117},
            new flaps522HotData{Altitude = 10000, Vr = 122, V2 = 117}
};
            foreach (flaps522HotData fhd in flaps522Hot)
            {
                context.flaps522HotData.Add(fhd);
            }
            context.SaveChanges();


            var flaps524Hot = new flaps524HotData[]
            {
            new flaps524HotData{Altitude = 0, Vr = 120, V2 = 122},
            new flaps524HotData{Altitude = 2000, Vr = 120, V2 = 122},
            new flaps524HotData{Altitude = 4000, Vr = 121, V2 = 122},
            new flaps524HotData{Altitude = 6000, Vr = 122, V2 = 122},
            new flaps524HotData{Altitude = 8000, Vr = 123, V2 = 122},
            new flaps524HotData{Altitude = 10000, Vr = 124, V2 = 122}
            };
            foreach (flaps524HotData fhd in flaps524Hot)
            {
                context.flaps524HotData.Add(fhd);
            }
            context.SaveChanges();

            var flaps526Hot = new flaps526HotData[]
            {
            new flaps526HotData{Altitude = 0, Vr = 126, V2 = 127},
            new flaps526HotData{Altitude = 2000, Vr = 126, V2 = 127},
            new flaps526HotData{Altitude = 4000, Vr = 127, V2 = 127},
            new flaps526HotData{Altitude = 6000, Vr = 128, V2 = 127},
            new flaps526HotData{Altitude = 8000, Vr = 129, V2 = 127},
            new flaps526HotData{Altitude = 10000, Vr = 130, V2 = 127}
            };
            foreach (flaps526HotData fhd in flaps526Hot)
            {
                context.flaps526HotData.Add(fhd);
            }
            context.SaveChanges();


            var flaps528Hot = new flaps528HotData[]
            {
            new flaps528HotData{Altitude = 0, Vr = 131, V2 = 132},
            new flaps528HotData{Altitude = 2000, Vr = 132, V2 = 132},
            new flaps528HotData{Altitude = 4000, Vr = 133, V2 = 132},
            new flaps528HotData{Altitude = 6000, Vr = 134, V2 = 132},
            new flaps528HotData{Altitude = 8000, Vr = 135, V2 = 132},
            new flaps528HotData{Altitude = 10000, Vr = 136, V2 = 132}
            };
            foreach (flaps528HotData fhd in flaps528Hot)
            {
                context.flaps528HotData.Add(fhd);
            }
            context.SaveChanges();

            var flaps529Hot = new flaps529HotData[]
            {
            new flaps529HotData{Altitude = 0, Vr = 135, V2 = 135},
            new flaps529HotData{Altitude = 2000, Vr = 136, V2 = 135},
            new flaps529HotData{Altitude = 4000, Vr = 137, V2 = 135},
            new flaps529HotData{Altitude = 6000, Vr = 138, V2 = 135},
            new flaps529HotData{Altitude = 8000, Vr = 138, V2 = 135},
            new flaps529HotData{Altitude = 10000, Vr = 140, V2 = 135}
            };
            foreach (flaps529HotData fhd in flaps529Hot)
            {
                context.flaps529HotData.Add(fhd);
            }
            context.SaveChanges();

            var flaps1018Cold = new flaps1018ColdData[]
            {
            new flaps1018ColdData{Altitude = 0, Vr = 100, V2 = 111},
            new flaps1018ColdData{Altitude = 2000, Vr = 100, V2 = 110},
            new flaps1018ColdData{Altitude = 4000, Vr = 100, V2 = 110},
            new flaps1018ColdData{Altitude = 6000, Vr = 100, V2 = 109},
            new flaps1018ColdData{Altitude = 8000, Vr = 100, V2 = 108},
            new flaps1018ColdData{Altitude = 10000, Vr = 100, V2 = 107}
            };
            foreach (flaps1018ColdData fcd in flaps1018Cold)
            {
                context.flaps1018ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps1020Cold = new flaps1020ColdData[]
            {
            new flaps1020ColdData{Altitude = 0, Vr = 100, V2 = 110},
            new flaps1020ColdData{Altitude = 2000, Vr = 100, V2 = 109},
            new flaps1020ColdData{Altitude = 4000, Vr = 100, V2 = 109},
            new flaps1020ColdData{Altitude = 6000, Vr = 100, V2 = 108},
            new flaps1020ColdData{Altitude = 8000, Vr = 100, V2 = 107},
            new flaps1020ColdData{Altitude = 10000, Vr = 101, V2 = 106}
            };
            foreach (flaps1020ColdData fcd in flaps1020Cold)
            {
                context.flaps1020ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps1022Cold = new flaps1022ColdData[]
            {
            new flaps1022ColdData{Altitude = 0, Vr = 103, V2 = 109},
            new flaps1022ColdData{Altitude = 2000, Vr = 105, V2 = 109},
            new flaps1022ColdData{Altitude = 4000, Vr = 105, V2 = 108},
            new flaps1022ColdData{Altitude = 6000, Vr = 105, V2 = 108},
            new flaps1022ColdData{Altitude = 8000, Vr = 106, V2 = 108},
            new flaps1022ColdData{Altitude = 10000, Vr = 108, V2 = 108}
            };
            foreach (flaps1022ColdData fcd in flaps1022Cold)
            {
                context.flaps1022ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps1024Cold = new flaps1024ColdData[]
            {
            new flaps1024ColdData{Altitude = 0, Vr = 109, V2 = 113},
            new flaps1024ColdData{Altitude = 2000, Vr = 110, V2 = 113},
            new flaps1024ColdData{Altitude = 4000, Vr = 111, V2 = 113},
            new flaps1024ColdData{Altitude = 6000, Vr = 111, V2 = 113},
            new flaps1024ColdData{Altitude = 8000, Vr = 112, V2 = 113},
            new flaps1024ColdData{Altitude = 10000, Vr = 113, V2 = 113}
            };
            foreach (flaps1024ColdData fcd in flaps1024Cold)
            {
                context.flaps1024ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps1026Cold = new flaps1026ColdData[]
            {
            new flaps1026ColdData{Altitude = 0, Vr = 115, V2 = 118},
            new flaps1026ColdData{Altitude = 2000, Vr = 116, V2 = 118},
            new flaps1026ColdData{Altitude = 4000, Vr = 116, V2 = 118},
            new flaps1026ColdData{Altitude = 6000, Vr = 117, V2 = 118},
            new flaps1026ColdData{Altitude = 8000, Vr = 118, V2 = 118},
            new flaps1026ColdData{Altitude = 10000, Vr = 119, V2 = 118}
            };
            foreach (flaps1026ColdData fcd in flaps1026Cold)
            {
                context.flaps1026ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps1028Cold = new flaps1028ColdData[]
            {
            new flaps1028ColdData{Altitude = 0, Vr = 120, V2 = 122},
            new flaps1028ColdData{Altitude = 2000, Vr = 121, V2 = 122},
            new flaps1028ColdData{Altitude = 4000, Vr = 122, V2 = 122},
            new flaps1028ColdData{Altitude = 6000, Vr = 122, V2 = 122},
            new flaps1028ColdData{Altitude = 8000, Vr = 123, V2 = 122},
            new flaps1028ColdData{Altitude = 10000, Vr = 124, V2 = 122}
            };
            foreach (flaps1028ColdData fcd in flaps1028Cold)
            {
                context.flaps1028ColdData.Add(fcd);
            }
            context.SaveChanges();

            var flaps1029Cold = new flaps1029ColdData[]
            {
            new flaps1029ColdData{Altitude = 0, Vr = 124, V2 = 125},
            new flaps1029ColdData{Altitude = 2000, Vr = 125, V2 = 125},
            new flaps1029ColdData{Altitude = 4000, Vr = 125, V2 = 125},
            new flaps1029ColdData{Altitude = 6000, Vr = 126, V2 = 125},
            new flaps1029ColdData{Altitude = 8000, Vr = 127, V2 = 125},
            new flaps1029ColdData{Altitude = 10000, Vr = 128, V2 = 125}
            };
            foreach (flaps1029ColdData fcd in flaps1029Cold)
            {
                context.flaps1029ColdData.Add(fcd);
            }
            context.SaveChanges();


            var flaps1018Hot = new flaps1018HotData[]
            {
            new flaps1018HotData{Altitude = 0, Vr = 124, V2 = 125},
            new flaps1018HotData{Altitude = 2000, Vr = 125, V2 = 125},
            new flaps1018HotData{Altitude = 4000, Vr = 125, V2 = 125},
            new flaps1018HotData{Altitude = 6000, Vr = 126, V2 = 125},
            new flaps1018HotData{Altitude = 8000, Vr = 127, V2 = 125},
            new flaps1018HotData{Altitude = 10000, Vr = 128, V2 = 125}
            };
            foreach (flaps1018HotData fhd2 in flaps1018Hot)
            {
                context.flaps1018HotData.Add(fhd2);
            }
            context.SaveChanges();

            var flaps1020Hot = new flaps1020HotData[]
{
            new flaps1020HotData{Altitude = 0, Vr = 124, V2 = 125},
            new flaps1020HotData{Altitude = 2000, Vr = 125, V2 = 125},
            new flaps1020HotData{Altitude = 4000, Vr = 125, V2 = 125},
            new flaps1020HotData{Altitude = 6000, Vr = 126, V2 = 125},
            new flaps1020HotData{Altitude = 8000, Vr = 127, V2 = 125},
            new flaps1020HotData{Altitude = 10000, Vr = 128, V2 = 125}
};
            foreach (flaps1020HotData fhd2 in flaps1020Hot)
            {
                context.flaps1020HotData.Add(fhd2);
            }
            context.SaveChanges();

            var flaps1022Hot = new flaps1022HotData[]
{
            new flaps1022HotData{Altitude = 0, Vr = 124, V2 = 125},
            new flaps1022HotData{Altitude = 2000, Vr = 125, V2 = 125},
            new flaps1022HotData{Altitude = 4000, Vr = 125, V2 = 125},
            new flaps1022HotData{Altitude = 6000, Vr = 126, V2 = 125},
            new flaps1022HotData{Altitude = 8000, Vr = 127, V2 = 125},
            new flaps1022HotData{Altitude = 10000, Vr = 128, V2 = 125}
};
            foreach (flaps1022HotData fhd2 in flaps1022Hot)
            {
                context.flaps1022HotData.Add(fhd2);
            }
            context.SaveChanges();

            var flaps1024Hot = new flaps1024HotData[]
{
            new flaps1024HotData{Altitude = 0, Vr = 124, V2 = 125},
            new flaps1024HotData{Altitude = 2000, Vr = 125, V2 = 125},
            new flaps1024HotData{Altitude = 4000, Vr = 125, V2 = 125},
            new flaps1024HotData{Altitude = 6000, Vr = 126, V2 = 125},
            new flaps1024HotData{Altitude = 8000, Vr = 127, V2 = 125},
            new flaps1024HotData{Altitude = 10000, Vr = 128, V2 = 125}
};
            foreach (flaps1024HotData fhd2 in flaps1024Hot)
            {
                context.flaps1024HotData.Add(fhd2);
            }
            context.SaveChanges();

            var flaps1026Hot = new flaps1026HotData[]
{
            new flaps1026HotData{Altitude = 0, Vr = 124, V2 = 125},
            new flaps1026HotData{Altitude = 2000, Vr = 125, V2 = 125},
            new flaps1026HotData{Altitude = 4000, Vr = 125, V2 = 125},
            new flaps1026HotData{Altitude = 6000, Vr = 126, V2 = 125},
            new flaps1026HotData{Altitude = 8000, Vr = 127, V2 = 125},
            new flaps1026HotData{Altitude = 10000, Vr = 128, V2 = 125}
};
            foreach (flaps1026HotData fhd2 in flaps1026Hot)
            {
                context.flaps1026HotData.Add(fhd2);
            }
            context.SaveChanges();

            var flaps1028Hot = new flaps1028HotData[]
{
            new flaps1028HotData{Altitude = 0, Vr = 124, V2 = 125},
            new flaps1028HotData{Altitude = 2000, Vr = 125, V2 = 125},
            new flaps1028HotData{Altitude = 4000, Vr = 125, V2 = 125},
            new flaps1028HotData{Altitude = 6000, Vr = 126, V2 = 125},
            new flaps1028HotData{Altitude = 8000, Vr = 127, V2 = 125},
            new flaps1028HotData{Altitude = 10000, Vr = 128, V2 = 125}
};
            foreach (flaps1028HotData fhd2 in flaps1028Hot)
            {
                context.flaps1028HotData.Add(fhd2);
            }
            context.SaveChanges();

            var flaps1029Hot = new flaps1029HotData[]
{
            new flaps1029HotData{Altitude = 0, Vr = 124, V2 = 125},
            new flaps1029HotData{Altitude = 2000, Vr = 125, V2 = 125},
            new flaps1029HotData{Altitude = 4000, Vr = 125, V2 = 125},
            new flaps1029HotData{Altitude = 6000, Vr = 126, V2 = 125},
            new flaps1029HotData{Altitude = 8000, Vr = 127, V2 = 125},
            new flaps1029HotData{Altitude = 10000, Vr = 128, V2 = 125}
};
            foreach (flaps1029HotData fhd2 in flaps1029Hot)
            {
                context.flaps1029HotData.Add(fhd2);
            }
            context.SaveChanges();
        }
        }

    }
    
         
