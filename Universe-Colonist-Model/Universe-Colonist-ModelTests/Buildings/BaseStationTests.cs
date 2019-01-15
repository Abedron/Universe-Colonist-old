using Xunit;
using Game.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Configurations;

namespace Game.Buildings.Tests
{
    public class BaseStationTests
    {
        [Fact]
        public void TryRaiseLevel()
        {
            var baseStation = new BaseStation(SetupProgressDefinition(), SetupBuildingDefinition());

            int xp = 2;

            Assert.True(baseStation.TryRaiseLevel(xp));
        }

        private BuildingDefinition[] SetupBuildingDefinition()
        {
            BuildingDefinition[] buildingDefinition = 
            {
                new BuildingDefinition()
                {
                    Level = 1,
                    RewardXp = 0
                }, new BuildingDefinition()
                {
                Level = 2,
                RewardXp = 107
                }, new BuildingDefinition()
                {
                Level = 3,
                RewardXp = 126
                }, new BuildingDefinition()
                {
                Level = 4,
                RewardXp = 198
                }, new BuildingDefinition()
                {
                Level = 5,
                RewardXp = 243
                }, new BuildingDefinition()
                {
                Level = 6,
                RewardXp = 288
                }, new BuildingDefinition()
                {
                Level = 7,
                RewardXp = 360
                }, new BuildingDefinition()
                {
                Level = 8,
                RewardXp = 405
                }, new BuildingDefinition()
                {
                Level = 9,
                RewardXp = 459
                }, new BuildingDefinition()
                {
                Level = 10,
                RewardXp = 513
                }, new BuildingDefinition()
                {
                Level = 11,
                RewardXp = 567
                }, new BuildingDefinition()
                {
                Level = 12,
                RewardXp = 612
                }, new BuildingDefinition()
                {
                Level = 13,
                RewardXp = 675
                }, new BuildingDefinition()
                {
                Level = 14,
                RewardXp = 738
                }, new BuildingDefinition()
                {
                Level = 15,
                RewardXp = 783
                }, new BuildingDefinition()
                {
                Level = 16,
                RewardXp = 837
                }, new BuildingDefinition()
                {
                Level = 17,
                RewardXp = 891
                }, new BuildingDefinition()
                {
                Level = 18,
                RewardXp = 945
                }, new BuildingDefinition()
                {
                Level = 19,
                RewardXp = 999
                }, new BuildingDefinition()
                {
                Level = 20,
                RewardXp = 1053
                }, new BuildingDefinition()
                {
                Level = 21,
                RewardXp = 1098
                }, new BuildingDefinition()
                {
                Level = 22,
                RewardXp = 1170
                }, new BuildingDefinition()
                {
                Level = 23,
                RewardXp = 1215
                }, new BuildingDefinition()
                {
                Level = 24,
                RewardXp = 1260
                }, new BuildingDefinition()
                {
                Level = 25,
                RewardXp = 1332
                }, new BuildingDefinition()
                {
                Level = 26,
                RewardXp = 1368
                }, new BuildingDefinition()
                {
                Level = 27,
                RewardXp = 1440
                }, new BuildingDefinition()
                {
                Level = 28,
                RewardXp = 1485
                }, new BuildingDefinition()
                {
                Level = 29,
                RewardXp = 1539
                }, new BuildingDefinition()
                {
                Level = 30,
                RewardXp = 1593
                }, new BuildingDefinition()
                {
                Level = 31,
                RewardXp = 1647
                }, new BuildingDefinition()
                {
                Level = 32,
                RewardXp = 1701
                }, new BuildingDefinition()
                {
                Level = 33,
                RewardXp = 1755
                }, new BuildingDefinition()
                {
                Level = 34,
                RewardXp = 1809
                }, new BuildingDefinition()
                {
                Level = 35,
                RewardXp = 1863
                }, new BuildingDefinition()
                {
                Level = 36,
                RewardXp = 1917
                }, new BuildingDefinition()
                {
                Level = 37,
                RewardXp = 1971
                }, new BuildingDefinition()
                {
                Level = 38,
                RewardXp = 2025
                }, new BuildingDefinition()
                {
                Level = 39,
                RewardXp = 2079
                }, new BuildingDefinition()
                {
                Level = 40,
                RewardXp = 2133
                }, new BuildingDefinition()
                {
                Level = 41,
                RewardXp = 2187
                }, new BuildingDefinition()
                {
                Level = 42,
                RewardXp = 2232
                }, new BuildingDefinition()
                {
                Level = 43,
                RewardXp = 2295
                }, new BuildingDefinition()
                {
                Level = 44,
                RewardXp = 2358
                }, new BuildingDefinition()
                {
                Level = 45,
                RewardXp = 2403
                }, new BuildingDefinition()
                {
                Level = 46,
                RewardXp = 2457
                }, new BuildingDefinition()
                {
                Level = 47,
                RewardXp = 2502
                }, new BuildingDefinition()
                {
                Level = 48,
                RewardXp = 2565
                }, new BuildingDefinition()
                {
                Level = 49,
                RewardXp = 2628
                }, new BuildingDefinition()
                {
                Level = 50,
                RewardXp = 2673
                }, new BuildingDefinition()
                {
                Level = 51,
                RewardXp = 2727
                }, new BuildingDefinition()
                {
                Level = 52,
                RewardXp = 2772
                }, new BuildingDefinition()
                {
                Level = 53,
                RewardXp = 2844
                }, new BuildingDefinition()
                {
                Level = 54,
                RewardXp = 2889
                }, new BuildingDefinition()
                {
                Level = 55,
                RewardXp = 2943
                }, new BuildingDefinition()
                {
                Level = 56,
                RewardXp = 2997
                }, new BuildingDefinition()
                {
                Level = 57,
                RewardXp = 3051
                }, new BuildingDefinition()
                {
                Level = 58,
                RewardXp = 3105
                }, new BuildingDefinition()
                {
                Level = 59,
                RewardXp = 3159
                }, new BuildingDefinition()
                {
                Level = 60,
                RewardXp = 3213
                }, new BuildingDefinition()
                {
                Level = 61,
                RewardXp = 3267
                }, new BuildingDefinition()
                {
                Level = 62,
                RewardXp = 3321
                }, new BuildingDefinition()
                {
                Level = 63,
                RewardXp = 3375
                }, new BuildingDefinition()
                {
                Level = 64,
                RewardXp = 3429
                }, new BuildingDefinition()
                {
                Level = 65,
                RewardXp = 3483
                }, new BuildingDefinition()
                {
                Level = 66,
                RewardXp = 3537
                }, new BuildingDefinition()
                {
                Level = 67,
                RewardXp = 3591
                }, new BuildingDefinition()
                {
                Level = 68,
                RewardXp = 3645
                }, new BuildingDefinition()
                {
                Level = 69,
                RewardXp = 3699
                }, new BuildingDefinition()
                {
                Level = 70,
                RewardXp = 3753
                }, new BuildingDefinition()
                {
                Level = 71,
                RewardXp = 3807
                }, new BuildingDefinition()
                {
                Level = 72,
                RewardXp = 3861
                }, new BuildingDefinition()
                {
                Level = 73,
                RewardXp = 3915
                }, new BuildingDefinition()
                {
                Level = 74,
                RewardXp = 3969
                }, new BuildingDefinition()
                {
                Level = 75,
                RewardXp = 4023
                }, new BuildingDefinition()
                {
                Level = 76,
                RewardXp = 4077
                }, new BuildingDefinition()
                {
                Level = 77,
                RewardXp = 4131
                }, new BuildingDefinition()
                {
                Level = 78,
                RewardXp = 4185
                }, new BuildingDefinition()
                {
                Level = 79,
                RewardXp = 4239
                }, new BuildingDefinition()
                {
                Level = 80,
                RewardXp = 4293
                }, new BuildingDefinition()
                {
                Level = 81,
                RewardXp = 4347
                }, new BuildingDefinition()
                {
                Level = 82,
                RewardXp = 4401
                }, new BuildingDefinition()
                {
                Level = 83,
                RewardXp = 4455
                }, new BuildingDefinition()
                {
                Level = 84,
                RewardXp = 4500
                }, new BuildingDefinition()
                {
                Level = 85,
                RewardXp = 4572
                }, new BuildingDefinition()
                {
                Level = 86,
                RewardXp = 4608
                }, new BuildingDefinition()
                {
                Level = 87,
                RewardXp = 4680
                }, new BuildingDefinition()
                {
                Level = 88,
                RewardXp = 4725
                }, new BuildingDefinition()
                {
                Level = 89,
                RewardXp = 4770
                }, new BuildingDefinition()
                {
                Level = 90,
                RewardXp = 4842
                }, new BuildingDefinition()
                {
                Level = 91,
                RewardXp = 4878
                }, new BuildingDefinition()
                {
                Level = 92,
                RewardXp = 4950
                }, new BuildingDefinition()
                {
                Level = 93,
                RewardXp = 4995
                }, new BuildingDefinition()
                {
                Level = 94,
                RewardXp = 5040
                }, new BuildingDefinition()
                {
                Level = 95,
                RewardXp = 5112
                }, new BuildingDefinition()
                {
                Level = 96,
                RewardXp = 5148
                }, new BuildingDefinition()
                {
                Level = 97,
                RewardXp = 5220
                }, new BuildingDefinition()
                {
                Level = 98,
                RewardXp = 5265
                }, new BuildingDefinition()
                {
                Level = 99,
                RewardXp = 5310
                }
            };

            return buildingDefinition;
        }

        private ProgressDefinition[] SetupProgressDefinition()
        {
            ProgressDefinition[] progressDefinition = new ProgressDefinition[99]
            {
                new ProgressDefinition()
                {
                    Level = 1,
                    Xp = 1
                },
                new ProgressDefinition()
                {
                    Level = 2,
                    Xp = 120
                },
                new ProgressDefinition()
                {
                    Level = 3,
                    Xp = 260
                },
                new ProgressDefinition()
                {
                    Level = 4,
                    Xp = 480
                },
                new ProgressDefinition()
                {
                    Level = 5,
                    Xp = 750
                },
                new ProgressDefinition()
                {
                    Level = 6,
                    Xp = 1070
                },
                new ProgressDefinition()
                {
                    Level = 7,
                    Xp = 1470
                },
                new ProgressDefinition()
                {
                    Level = 8,
                    Xp = 1920
                },
                new ProgressDefinition()
                {
                    Level = 9,
                    Xp = 2430
                },
                new ProgressDefinition()
                {
                    Level = 10,
                    Xp = 3000
                },
                new ProgressDefinition()
                {
                    Level = 11,
                    Xp = 3630
                },
                new ProgressDefinition()
                {
                    Level = 12,
                    Xp = 4310
                },
                new ProgressDefinition()
                {
                    Level = 13,
                    Xp = 5060
                },
                new ProgressDefinition()
                {
                    Level = 14,
                    Xp = 5880
                },
                new ProgressDefinition()
                {
                    Level = 15,
                    Xp = 6750
                },
                new ProgressDefinition()
                {
                    Level = 16,
                    Xp = 7680
                },
                new ProgressDefinition()
                {
                    Level = 17,
                    Xp = 8670
                },
                new ProgressDefinition()
                {
                    Level = 18,
                    Xp = 9720
                },
                new ProgressDefinition()
                {
                    Level = 19,
                    Xp = 10830
                },
                new ProgressDefinition()
                {
                    Level = 20,
                    Xp = 12000
                },
                new ProgressDefinition()
                {
                    Level = 21,
                    Xp = 13220
                },
                new ProgressDefinition()
                {
                    Level = 22,
                    Xp = 14520
                },
                new ProgressDefinition()
                {
                    Level = 23,
                    Xp = 15870
                },
                new ProgressDefinition()
                {
                    Level = 24,
                    Xp = 17270
                },
                new ProgressDefinition()
                {
                    Level = 25,
                    Xp = 18750
                },
                new ProgressDefinition()
                {
                    Level = 26,
                    Xp = 20270
                },
                new ProgressDefinition()
                {
                    Level = 27,
                    Xp = 21870
                },
                new ProgressDefinition()
                {
                    Level = 28,
                    Xp = 23520
                },
                new ProgressDefinition()
                {
                    Level = 29,
                    Xp = 25230
                },
                new ProgressDefinition()
                {
                    Level = 30,
                    Xp = 27000
                },
                new ProgressDefinition()
                {
                    Level = 31,
                    Xp = 28830
                },
                new ProgressDefinition()
                {
                    Level = 32,
                    Xp = 30720
                },
                new ProgressDefinition()
                {
                    Level = 33,
                    Xp = 32670
                },
                new ProgressDefinition()
                {
                    Level = 34,
                    Xp = 34680
                },
                new ProgressDefinition()
                {
                    Level = 35,
                    Xp = 36750
                },
                new ProgressDefinition()
                {
                    Level = 36,
                    Xp = 38880
                },
                new ProgressDefinition()
                {
                    Level = 37,
                    Xp = 41070
                },
                new ProgressDefinition()
                {
                    Level = 38,
                    Xp = 43320
                },
                new ProgressDefinition()
                {
                    Level = 39,
                    Xp = 45630
                },
                new ProgressDefinition()
                {
                    Level = 40,
                    Xp = 48000
                },
                new ProgressDefinition()
                {
                    Level = 41,
                    Xp = 50430
                },
                new ProgressDefinition()
                {
                    Level = 42,
                    Xp = 52910
                },
                new ProgressDefinition()
                {
                    Level = 43,
                    Xp = 55460
                },
                new ProgressDefinition()
                {
                    Level = 44,
                    Xp = 58080
                },
                new ProgressDefinition()
                {
                    Level = 45,
                    Xp = 60750
                },
                new ProgressDefinition()
                {
                    Level = 46,
                    Xp = 63480
                },
                new ProgressDefinition()
                {
                    Level = 47,
                    Xp = 66260
                },
                new ProgressDefinition()
                {
                    Level = 48,
                    Xp = 69110
                },
                new ProgressDefinition()
                {
                    Level = 49,
                    Xp = 72030
                },
                new ProgressDefinition()
                {
                    Level = 50,
                    Xp = 75000
                },
                new ProgressDefinition()
                {
                    Level = 51,
                    Xp = 78030
                },
                new ProgressDefinition()
                {
                    Level = 52,
                    Xp = 81110
                },
                new ProgressDefinition()
                {
                    Level = 53,
                    Xp = 84270
                },
                new ProgressDefinition()
                {
                    Level = 54,
                    Xp = 87480
                },
                new ProgressDefinition()
                {
                    Level = 55,
                    Xp = 90750
                },
                new ProgressDefinition()
                {
                    Level = 56,
                    Xp = 94080
                },
                new ProgressDefinition()
                {
                    Level = 57,
                    Xp = 97470
                },
                new ProgressDefinition()
                {
                    Level = 58,
                    Xp = 100920
                },
                new ProgressDefinition()
                {
                    Level = 59,
                    Xp = 104430
                },
                new ProgressDefinition()
                {
                    Level = 60,
                    Xp = 108000
                },
                new ProgressDefinition()
                {
                    Level = 61,
                    Xp = 111630
                },
                new ProgressDefinition()
                {
                    Level = 62,
                    Xp = 115320
                },
                new ProgressDefinition()
                {
                    Level = 63,
                    Xp = 119070
                },
                new ProgressDefinition()
                {
                    Level = 64,
                    Xp = 122880
                },
                new ProgressDefinition()
                {
                    Level = 65,
                    Xp = 126750
                },
                new ProgressDefinition()
                {
                    Level = 66,
                    Xp = 130680
                },
                new ProgressDefinition()
                {
                    Level = 67,
                    Xp = 134670
                },
                new ProgressDefinition()
                {
                    Level = 68,
                    Xp = 138720
                },
                new ProgressDefinition()
                {
                    Level = 69,
                    Xp = 142830
                },
                new ProgressDefinition()
                {
                    Level = 70,
                    Xp = 147000
                },
                new ProgressDefinition()
                {
                    Level = 71,
                    Xp = 151230
                },
                new ProgressDefinition()
                {
                    Level = 72,
                    Xp = 155520
                },
                new ProgressDefinition()
                {
                    Level = 73,
                    Xp = 159870
                },
                new ProgressDefinition()
                {
                    Level = 74,
                    Xp = 164280
                },
                new ProgressDefinition()
                {
                    Level = 75,
                    Xp = 168750
                },
                new ProgressDefinition()
                {
                    Level = 76,
                    Xp = 173280
                },
                new ProgressDefinition()
                {
                    Level = 77,
                    Xp = 177870
                },
                new ProgressDefinition()
                {
                    Level = 78,
                    Xp = 182520
                },
                new ProgressDefinition()
                {
                    Level = 79,
                    Xp = 187230
                },
                new ProgressDefinition()
                {
                    Level = 80,
                    Xp = 192000
                },
                new ProgressDefinition()
                {
                    Level = 81,
                    Xp = 196830
                },
                new ProgressDefinition()
                {
                    Level = 82,
                    Xp = 201720
                },
                new ProgressDefinition()
                {
                    Level = 83,
                    Xp = 206670
                },
                new ProgressDefinition()
                {
                    Level = 84,
                    Xp = 211670
                },
                new ProgressDefinition()
                {
                    Level = 85,
                    Xp = 216750
                },
                new ProgressDefinition()
                {
                    Level = 86,
                    Xp = 221870
                },
                new ProgressDefinition()
                {
                    Level = 87,
                    Xp = 227070
                },
                new ProgressDefinition()
                {
                    Level = 88,
                    Xp = 232320
                },
                new ProgressDefinition()
                {
                    Level = 89,
                    Xp = 237620
                },
                new ProgressDefinition()
                {
                    Level = 90,
                    Xp = 243000
                },
                new ProgressDefinition()
                {
                    Level = 91,
                    Xp = 248420
                },
                new ProgressDefinition()
                {
                    Level = 92,
                    Xp = 253920
                },
                new ProgressDefinition()
                {
                    Level = 93,
                    Xp = 259470
                },
                new ProgressDefinition()
                {
                    Level = 94,
                    Xp = 265070
                },
                new ProgressDefinition()
                {
                    Level = 95,
                    Xp = 270750
                },
                new ProgressDefinition()
                {
                    Level = 96,
                    Xp = 276470
                },
                new ProgressDefinition()
                {
                    Level = 97,
                    Xp = 282270
                },
                new ProgressDefinition()
                {
                    Level = 98,
                    Xp = 288120
                },
                new ProgressDefinition()
                {
                    Level = 99,
                    Xp = 294020
                }
            };


            return progressDefinition;
        }
    }
}