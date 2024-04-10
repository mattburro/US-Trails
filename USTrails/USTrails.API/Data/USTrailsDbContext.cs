using Microsoft.EntityFrameworkCore;
using USTrails.API.Models.Domain;

namespace USTrails.API.Data
{
    public class USTrailsDbContext : DbContext
    {
        public USTrailsDbContext(DbContextOptions<USTrailsDbContext> options) : base(options) { }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Trail> Trails { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create uni-directional many-to-many relationship between Trails and States
            modelBuilder.Entity<Trail>().HasMany(t => t.States).WithMany().UsingEntity<StateTrail>();

            // Always include all Trail navigation properties
            modelBuilder.Entity<Trail>().Navigation(t => t.Difficulty).AutoInclude();
            modelBuilder.Entity<Trail>().Navigation(t => t.States).AutoInclude();

            // Seed difficulty data
            var difficulties = new List<Difficulty>
            {
                new Difficulty
                {
                    Id = 1,
                    Name = "Easy"
                },
                new Difficulty
                {
                    Id = 2,
                    Name = "Moderate"
                },
                new Difficulty
                {
                    Id = 3,
                    Name = "Moderately Strenuous"
                },
                new Difficulty
                {
                    Id = 4,
                    Name = "Strenuous"
                },
                new Difficulty
                {
                    Id = 5,
                    Name = "Very Strenuous"
                }
            };
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed state data
            var states = new List<State>
            {
                new State
                {
                    Id = 1,
                    Name = "Alabama",
                    Code = "AL",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Alabama_in_United_States.svg/1280px-Alabama_in_United_States.svg.png"
                },
                new State
                {
                    Id = 2,
                    Name = "Alaska",
                    Code = "AK",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Alaska_in_United_States_%28US50%29.svg/1280px-Alaska_in_United_States_%28US50%29.svg.png"
                },
                new State
                {
                    Id = 3,
                    Name = "Arizona",
                    Code = "AZ",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/Arizona_in_United_States.svg/1280px-Arizona_in_United_States.svg.png"
                },
                new State
                {
                    Id = 4,
                    Name = "Arkansas",
                    Code = "AR",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Arkansas_in_United_States.svg/1280px-Arkansas_in_United_States.svg.png"
                },
                new State
                {
                    Id = 5,
                    Name = "California",
                    Code = "CA",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/California_in_United_States.svg/1280px-California_in_United_States.svg.png"
                },
                new State
                {
                    Id = 6,
                    Name = "Colorado",
                    Code = "CO",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Colorado_in_United_States.svg/1280px-Colorado_in_United_States.svg.png"
                },
                new State
                {
                    Id = 7,
                    Name = "Connecticut",
                    Code = "CT",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Connecticut_in_United_States_%28zoom%29.svg/1280px-Connecticut_in_United_States_%28zoom%29.svg.png"
                },
                new State
                {
                    Id = 8,
                    Name = "Delaware",
                    Code = "DE",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Delaware_in_United_States_%28zoom%29.svg/1280px-Delaware_in_United_States_%28zoom%29.svg.png"
                },
                new State
                {
                    Id = 9,
                    Name = "Florida",
                    Code = "FL",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/15/Florida_in_United_States.svg/1280px-Florida_in_United_States.svg.png"
                },
                new State
                {
                    Id = 10,
                    Name = "Georgia",
                    Code = "GA",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Georgia_in_United_States.svg/1280px-Georgia_in_United_States.svg.png"
                },
                new State
                {
                    Id = 11,
                    Name = "Hawaii",
                    Code = "HI",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Hawaii_in_United_States_%28US50%29_%28%2Bgrid%29_%28zoom%29_%28W3%29.svg/1280px-Hawaii_in_United_States_%28US50%29_%28%2Bgrid%29_%28zoom%29_%28W3%29.svg.png"
                },
                new State
                {
                    Id = 12,
                    Name = "Idaho",
                    Code = "ID",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Idaho_in_United_States.svg/1280px-Idaho_in_United_States.svg.png"
                },
                new State
                {
                    Id = 13,
                    Name = "Illinois",
                    Code = "IL",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Illinois_in_United_States.svg/1280px-Illinois_in_United_States.svg.png"
                },
                new State
                {
                    Id = 14,
                    Name = "Indiana",
                    Code = "IN",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d2/Indiana_in_United_States.svg/1280px-Indiana_in_United_States.svg.png"
                },
                new State
                {
                    Id = 15,
                    Name = "Iowa",
                    Code = "IA",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Iowa_in_United_States.svg/1280px-Iowa_in_United_States.svg.png"
                },
                new State
                {
                    Id = 16,
                    Name = "Kansas",
                    Code = "KS",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Kansas_in_United_States.svg/1280px-Kansas_in_United_States.svg.png"
                },
                new State
                {
                    Id = 17,
                    Name = "Kentucky",
                    Code = "KY",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/Kentucky_in_United_States.svg/1280px-Kentucky_in_United_States.svg.png"
                },
                new State
                {
                    Id = 18,
                    Name = "Louisiana",
                    Code = "LA",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/Louisiana_in_United_States.svg/1280px-Louisiana_in_United_States.svg.png"
                },
                new State
                {
                    Id = 19,
                    Name = "Maine",
                    Code = "ME",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Maine_in_United_States.svg/1280px-Maine_in_United_States.svg.png"
                },
                new State
                {
                    Id = 20,
                    Name = "Maryland",
                    Code = "MD",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Maryland_in_United_States_%28zoom%29.svg/1280px-Maryland_in_United_States_%28zoom%29.svg.png"
                },
                new State
                {
                    Id = 21,
                    Name = "Massachusetts",
                    Code = "MA",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Massachusetts_in_United_States.svg/1280px-Massachusetts_in_United_States.svg.png"
                },
                new State
                {
                    Id = 22,
                    Name = "Michigan",
                    Code = "MI",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Michigan_in_United_States.svg/1280px-Michigan_in_United_States.svg.png"
                },
                new State
                {
                    Id = 23,
                    Name = "Minnesota",
                    Code = "MN",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/81/Minnesota_in_United_States.svg/1280px-Minnesota_in_United_States.svg.png"
                },
                new State
                {
                    Id = 24,
                    Name = "Mississippi",
                    Code = "MS",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Mississippi_in_United_States.svg/1280px-Mississippi_in_United_States.svg.png"
                },
                new State
                {
                    Id = 25,
                    Name = "Missouri",
                    Code = "MO",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Missouri_in_United_States.svg/1280px-Missouri_in_United_States.svg.png"
                },
                new State
                {
                    Id = 26,
                    Name = "Montana",
                    Code = "MT",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Montana_in_United_States.svg/1280px-Montana_in_United_States.svg.png"
                },
                new State
                {
                    Id = 27,
                    Name = "Nebraska",
                    Code = "NE",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Nebraska_in_United_States.svg/1280px-Nebraska_in_United_States.svg.png"
                },
                new State
                {
                    Id = 28,
                    Name = "Nevada",
                    Code = "NV",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Nevada_in_United_States.svg/1280px-Nevada_in_United_States.svg.png"
                },
                new State
                {
                    Id = 29,
                    Name = "New Hampshire",
                    Code = "NH",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/New_Hampshire_in_United_States.svg/1280px-New_Hampshire_in_United_States.svg.png"
                },
                new State
                {
                    Id = 30,
                    Name = "New Jersey",
                    Code = "NJ",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/New_Jersey_in_United_States_%28zoom%29.svg/1280px-New_Jersey_in_United_States_%28zoom%29.svg.png"
                },
                new State
                {
                    Id = 31,
                    Name = "New Mexico",
                    Code = "NM",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/New_Mexico_in_United_States.svg/1280px-New_Mexico_in_United_States.svg.png"
                },
                new State
                {
                    Id = 32,
                    Name = "New York",
                    Code = "NY",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/New_York_in_United_States.svg/1280px-New_York_in_United_States.svg.png"
                },
                new State
                {
                    Id = 33,
                    Name = "North Carolina",
                    Code = "NC",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/North_Carolina_in_United_States.svg/1280px-North_Carolina_in_United_States.svg.png"
                },
                new State
                {
                    Id = 34,
                    Name = "North Dakota",
                    Code = "ND",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/North_Dakota_in_United_States.svg/1280px-North_Dakota_in_United_States.svg.png"
                },
                new State
                {
                    Id = 35,
                    Name = "Ohio",
                    Code = "OH",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/58/Ohio_in_United_States.svg/1280px-Ohio_in_United_States.svg.png"
                },
                new State
                {
                    Id = 36,
                    Name = "Oklahoma",
                    Code = "OK",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Oklahoma_in_United_States.svg/1280px-Oklahoma_in_United_States.svg.png"
                },
                new State
                {
                    Id = 37,
                    Name = "Oregon",
                    Code = "OR",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Oregon_in_United_States.svg/1280px-Oregon_in_United_States.svg.png"
                },
                new State
                {
                    Id = 38,
                    Name = "Pennsylvania",
                    Code = "PA",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Pennsylvania_in_United_States.svg/1280px-Pennsylvania_in_United_States.svg.png"
                },
                new State
                {
                    Id = 39,
                    Name = "Rhode Island",
                    Code = "RI",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Rhode_Island_in_United_States_%28zoom%29_%28extra_close%29.svg/1280px-Rhode_Island_in_United_States_%28zoom%29_%28extra_close%29.svg.png"
                },
                new State
                {
                    Id = 40,
                    Name = "South Carolina",
                    Code = "SC",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8e/South_Carolina_in_United_States.svg/1280px-South_Carolina_in_United_States.svg.png"
                },
                new State
                {
                    Id = 41,
                    Name = "South Dakota",
                    Code = "SD",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/South_Dakota_in_United_States.svg/1280px-South_Dakota_in_United_States.svg.png"
                },
                new State
                {
                    Id = 42,
                    Name = "Tennessee",
                    Code = "TN",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Tennessee_in_United_States.svg/1280px-Tennessee_in_United_States.svg.png"
                },
                new State
                {
                    Id = 43,
                    Name = "Texas",
                    Code = "TX",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/Texas_in_United_States.svg/1280px-Texas_in_United_States.svg.png"
                },
                new State
                {
                    Id = 44,
                    Name = "Utah",
                    Code = "UT",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Utah_in_United_States.svg/1280px-Utah_in_United_States.svg.png"
                },
                new State
                {
                    Id = 45,
                    Name = "Vermont",
                    Code = "VT",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Vermont_in_United_States_%28zoom%29.svg/1280px-Vermont_in_United_States_%28zoom%29.svg.png"
                },
                new State
                {
                    Id = 46,
                    Name = "Virginia",
                    Code = "VA",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c6/Virginia_in_United_States.svg/1280px-Virginia_in_United_States.svg.png"
                },
                new State
                {
                    Id = 47,
                    Name = "Washington",
                    Code = "WA",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Washington_in_United_States.svg/1280px-Washington_in_United_States.svg.png"
                },
                new State
                {
                    Id = 48,
                    Name = "West Virginia",
                    Code = "WV",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2a/West_Virginia_in_United_States.svg/1280px-West_Virginia_in_United_States.svg.png"
                },
                new State
                {
                    Id = 49,
                    Name = "Wisconsin",
                    Code = "WI",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Wisconsin_in_United_States.svg/1280px-Wisconsin_in_United_States.svg.png"
                },
                new State
                {
                    Id = 50,
                    Name = "Wyoming",
                    Code = "WY",
                    StateImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Wyoming_in_United_States.svg/1280px-Wyoming_in_United_States.svg.png"
                }
            };
            modelBuilder.Entity<State>().HasData(states);

            // Seed trail data
            var trails = new List<Trail>
            {
                // 11 National Scenic Trails
                new Trail
                {
                    Id = Guid.Parse("0a8925e9-55d8-492f-8bb4-5f7b7a8c14d5"),
                    Name = "Appalachian National Scenic Trail",
                    Description = "The Appalachian National Scenic Trail is a hiking trail in the Eastern United States, extending " +
                        "between Springer Mountain in Georgia and Mount Katahdin in Maine. The Appalachian Trail " +
                        "Conservancy claims the Appalachian Trail to be the longest hiking-only trail in the world. " +
                        "More than three million people hike segments of the trail each year.",
                    LengthInMi = 2197.4,
                    TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0f/Map_of_Appalachian_Trail.png",
                    DifficultyId = 4
                },
                new Trail
                {
                    Id = Guid.Parse("b6d432b2-442d-4cf6-964f-b88c72bdc972"),
                    Name = "Pacific Crest National Scenic Trail",
                    Description = "The Pacific Crest National Scenic Trail is a long-distance hiking and equestrian trail closely " +
                        "aligned with the highest portion of the Cascade and Sierra Nevada mountain ranges. The trail's " +
                        "southern terminus is next to the Mexico–United States border, just south of Campo, California, " +
                        "and its northern terminus is on the Canada–US border.",
                    LengthInMi = 2653.0,
                    TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/3f/Locator_Map_of_the_Pacific_Crest_Trail.png",
                    DifficultyId = 2
                },
                new Trail
                {
                    Id = Guid.Parse("7c51cf47-a26e-401d-85ea-b906f66b6413"),
                    Name = "Continental Divide National Scenic Trail",
                    Description = "The Continental Divide National Scenic Trail is a trail between the U.S. border with Chihuahua, Mexico " +
                        "and the border with Alberta, Canada. It follows the Continental Divide of the Americas along the Rocky " +
                        "Mountains. Near the Canadian border the trail crosses Triple Divide Pass.",
                    LengthInMi = 3028.0,
                    TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/ba/Condivm.png",
                    DifficultyId = 5
                },
                new Trail
                {
                    Id = Guid.Parse("6a403145-11aa-4194-9108-4bbab8700d09"),
                    Name = "North Country National Scenic Trail",
                    Description = "The North Country National Scenic Trail is a long-distance hiking trail in the Midwestern and Northeastern " +
                        "United States. The trail extends from Lake Sakakawea State Park in North Dakota to the Appalachian Trail " +
                        "in Green Mountain National Forest in Vermont.",
                    LengthInMi = 4800.0,
                    TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/41/North_Country_Trail_Locator_Map_US.svg",
                    DifficultyId = 3
                },
                new Trail
                {
                    Id = Guid.Parse("a4b04586-c423-49a6-8132-852666353eb2"),
                    Name = "Ice Age National Scenic Trail",
                    Description = "The Ice Age National Scenic Trail is a trail that roughly follows the location of the terminal moraine from " +
                        "the last Ice Age. The western end of the trail is at Interstate State Park along the St. Croix River, " +
                        "and the eastern terminus lies at Potawatomi State Park near the city of Sturgeon Bay.",
                    LengthInMi = 1200.0,
                    TrailImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/47/USNPS_Ice-Age-Trail_6d05am.jpg",
                    DifficultyId = 1
                },
                new Trail
                {
                    Id = Guid.Parse("f5357e24-c626-4615-985b-7d836fa52369"),
                    Name = "Potomac Heritage National Scenic Trail",
                    Description = "The Potomac Heritage National Scenic Trail is a trail spanning parts of the mid-Atlantic region. The trail " +
                        "network includes existing and planned sections, tracing the natural, historical, and cultural features of " +
                        "the Potomac River corridor, the upper Ohio River watershed, and a portion of the Rappahannock River watershed.",
                    LengthInMi = 710.0,
                    TrailImageUrl = "https://pnts.org/new/wp-content/uploads/2014/12/Potomac-Heritage-NST-Map.png",
                    DifficultyId = 2
                },
                new Trail
                {
                    Id = Guid.Parse("65f33fea-2ac4-4419-acd6-f44281ee643d"),
                    Name = "Natchez Trace National Scenic Trail",
                    Description = "The Natchez Trace National Scenic Trail is a trail whose route generally follows sections of the Natchez Trace Parkway. " +
                        "It commemorates the historic Natchez Trace, an ancient path that began as a wildlife and Native American trail, and " +
                        "has a rich history of use by colonizers, \"Kaintuck\" boatmen, post riders, and military men.",
                    LengthInMi = 60.0,
                    TrailImageUrl = "https://pnts.org/new/wp-content/uploads/2014/12/Pink-Natchez-Trace-Map.png",
                    DifficultyId = 3
                },
                new Trail
                {
                    Id = Guid.Parse("4c4d7e5e-b7c9-4a0b-9337-9de4e25d208b"),
                    Name = "Florida National Scenic Trail",
                    Description = "The Florida National Scenic Trail runs from Big Cypress National Preserve to Fort Pickens at Gulf Islands National " +
                        "Seashore, Pensacola Beach. It provides permanent non-motorized recreation opportunity for hiking and other " +
                        "compatible activities and is within an hour of most Floridians.",
                    LengthInMi = 1500.0,
                    TrailImageUrl = "https://www.journaloffloridastudies.org/images/Florida-Trail-Map.jpg",
                    DifficultyId = 3
                },
                new Trail
                {
                    Id = Guid.Parse("83c81f00-f422-499c-bb50-1d0405c2aea7"),
                    Name = "Arizona National Scenic Trail",
                    Description = "The Arizona National Scenic Trail is a trail from Mexico to Utah that traverses the whole north–south length of " +
                        "Arizona. It begins at the Coronado National Memorial near the US–Mexico border and moves north through parts " +
                        "of the Huachuca, Santa Rita, and Rincon Mountains, terminating near the Arizona–Utah border in the Kaibab Plateau " +
                        "region. The trail is designed as a primitive trail for hiking, equestrians, mountain biking, and even cross " +
                        "country skiing, showcasing the wide variety of mountain ranges and ecosystems of Arizona.",
                    LengthInMi = 800.0,
                    TrailImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKKuZO-kxEsTowdn4Mu9j46IAqPXd5KUW89vSi5XUu5g&s",
                    DifficultyId = 2
                },
                new Trail
                {
                    Id = Guid.Parse("da7d3e68-38cf-41d3-9291-0e2bc2bcedfa"),
                    Name = "New England National Scenic Trail",
                    Description = "The New England National Scenic Trail is a trail in southern New England, which includes most of the three single trails " +
                        "Metacomet-Monadnock Trail, Mattabesett Trail, and Metacomet Trail. It extends through 41 communities from Guilford, " +
                        "Connecticut, at Long Island Sound over the Metacomet Ridge, through the highlands of the Pioneer Valley of " +
                        "Massachusetts, to the New Hampshire state border.",
                    LengthInMi = 215.0,
                    TrailImageUrl = "https://i0.wp.com/www.jeffryanauthor.com/wp-content/uploads/2019/06/Screen-Shot-2019-06-05-at-4.22.01-PM-1.jpg",
                    DifficultyId = 3
                },
                new Trail
                {
                    Id = Guid.Parse("01469432-69c7-4e24-838d-6f74886caec9"),
                    Name = "Pacific Northwest National Scenic Trail",
                    Description = "The Pacific Northwest National Scenic Trail is a hiking trail running from the Continental Divide in Montana to the Pacific " +
                        "Ocean on Washington's Olympic Coast. Along the way, the it crosses three national parks, seven national forests, and " +
                        "two other national scenic trails.",
                    LengthInMi = 1200.0,
                    TrailImageUrl = "https://ep1.pinkbike.org/trailstaticmap/35000/route_35184_0_600x315.png",
                    DifficultyId = 5
                }

                // TODO: 19 National Historic Trails
            };
            modelBuilder.Entity<Trail>().HasData(trails);

            // Seed StateTrail data
            var stateTrails = new List<StateTrail>
            {
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "CT").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "GA").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MA").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MD").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "ME").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "NC").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "NH").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "NJ").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "PA").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "TN").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "VA").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "VT").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Appalachian National Scenic Trail").Id, StateId = states.Single(s => s.Code == "WV").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "Pacific Crest National Scenic Trail").Id, StateId = states.Single(s => s.Code == "CA").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Pacific Crest National Scenic Trail").Id, StateId = states.Single(s => s.Code == "OR").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Pacific Crest National Scenic Trail").Id, StateId = states.Single(s => s.Code == "WA").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "Continental Divide National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MT").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Continental Divide National Scenic Trail").Id, StateId = states.Single(s => s.Code == "ID").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Continental Divide National Scenic Trail").Id, StateId = states.Single(s => s.Code == "WY").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Continental Divide National Scenic Trail").Id, StateId = states.Single(s => s.Code == "CO").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Continental Divide National Scenic Trail").Id, StateId = states.Single(s => s.Code == "NM").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "North Country National Scenic Trail").Id, StateId = states.Single(s => s.Code == "ND").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "North Country National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MN").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "North Country National Scenic Trail").Id, StateId = states.Single(s => s.Code == "WI").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "North Country National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MI").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "North Country National Scenic Trail").Id, StateId = states.Single(s => s.Code == "OH").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "North Country National Scenic Trail").Id, StateId = states.Single(s => s.Code == "PA").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "North Country National Scenic Trail").Id, StateId = states.Single(s => s.Code == "NY").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "North Country National Scenic Trail").Id, StateId = states.Single(s => s.Code == "VT").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "Ice Age National Scenic Trail").Id, StateId = states.Single(s => s.Code == "WI").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "Potomac Heritage National Scenic Trail").Id, StateId = states.Single(s => s.Code == "VA").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Potomac Heritage National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MD").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Potomac Heritage National Scenic Trail").Id, StateId = states.Single(s => s.Code == "PA").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "Natchez Trace National Scenic Trail").Id, StateId = states.Single(s => s.Code == "AL").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Natchez Trace National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MS").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Natchez Trace National Scenic Trail").Id, StateId = states.Single(s => s.Code == "TN").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "Florida National Scenic Trail").Id, StateId = states.Single(s => s.Code == "FL").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "Arizona National Scenic Trail").Id, StateId = states.Single(s => s.Code == "AZ").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "New England National Scenic Trail").Id, StateId = states.Single(s => s.Code == "CT").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "New England National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MA").Id },

                new StateTrail { TrailId = trails.Single(t => t.Name == "Pacific Northwest National Scenic Trail").Id, StateId = states.Single(s => s.Code == "MT").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Pacific Northwest National Scenic Trail").Id, StateId = states.Single(s => s.Code == "ID").Id },
                new StateTrail { TrailId = trails.Single(t => t.Name == "Pacific Northwest National Scenic Trail").Id, StateId = states.Single(s => s.Code == "WA").Id },
            };
            modelBuilder.Entity<StateTrail>().HasData(stateTrails);
        }
    }
}
