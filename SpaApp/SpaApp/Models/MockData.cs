namespace SpaApp.Models
{
    public static class MockData
    {
        public static Tab[] GetTabs()
        {
            return new Tab[] {
                new Tab()
                {
                    Id = 1,
                    TabContents = new TabContent[]
                    {
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Swedish Massage", Price = "$39"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Full Body Massage", Price = "$42"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Foot Massage", Price = "$29"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Choclate Massage", Price = "$17"
                        }
                    }
                },
                new Tab()
                {
                    Id = 2,
                    TabContents = new TabContent[]
                    {
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Signature Facial", Price = "$22"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Organic Facial", Price = "$40"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Deep Cleansing Facial", Price = "$31"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Anti Aging Facial", Price = "$19"
                        }
                    }
                },
                new Tab()
                {
                    Id = 3,
                    TabContents = new TabContent[]
                    {
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Papaya Wrap", Price = "$51"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Cucumber Wrap", Price = "$29"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Whitening Wrap", Price = "$39"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Signature Wrap", Price = "$20"
                        }
                    }
                },
                new Tab()
                {
                    Id = 4,
                    TabContents = new TabContent[]
                    {
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Menicure", Price = "$39"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Pedicure", Price = "$42"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Rice Body Scrub", Price = "$29"
                        },
                        new TabContent()
                        {
                            Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt quos harum officia eaque nobis ut.", Name = "Corn Cub Scrub", Price = "$17"
                        }
                    }
                }
            };
        }

        public static Slider[] GetSliders()
        {
            return new Slider[]
            {
                new Slider() { Description = "Globalization fairness non-partisan visionary, institutions Aga Khan resolve. Results public-private partnerships, international development elevate scalable.\"", Name = "John Doe", LocationName = "New York Magazine" },
                new Slider() { Description = "\"Medicine; experience in the field climate change achieve voice public-private partnerships process our ambitions. Sanitation.\"", Name = "Mary Jane", LocationName = "Chicago News" },
                new Slider() { Description = "\"Healthcare forward-thinking public service, social innovation making progress. Arab Spring social analysis, equality treatment, diversification.\"", Name = "Luis Frank", LocationName = "France" }
            };
        }

        public static FeatureBox[] GetFeatureBoxes()
        {
            return new FeatureBox[]
            {
                new FeatureBox()
                {
                    Title  = "Beauty.",
                    SubTitle = "Your Property in Good Hands.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Eligendi rem, facilis nobis voluptatum est voluptatem accusamus molestiae eaque perspiciatis mollitia."
                },
                new FeatureBox()
                {
                    Title  = "Spa.",
                    SubTitle = "Construction Process Organized.",
                    Description = "Porro repellat vero sapiente amet vitae quibusdam necessitatibus consectetur, labore totam. Accusamus perspiciatis asperiores labore esse."
                },
                new FeatureBox()
                {
                    Title  = "Relax.",
                    SubTitle = "We have got you Covered.",
                    Description = "Quos, non, esse eligendi ab accusantium voluptatem. Maxime eligendi beatae, atque tempora ullam. Vitae delectus quia, consequuntur rerum quo."
                }
            };
        }

        public static Counter[] GetCounters()
        {
            return new Counter[]
            {
                new Counter()
                {
                    From = 10,
                    To = 21,
                    Title = "Spa Branches",
                    Icon = "leaves"
                },
                new Counter()
                {
                    From = 100,
                    To = 8514,
                    Title = "Employees",
                    Icon = "woman"
                },
                new Counter()
                {
                    From = 100,
                    To = 458,
                    Title = "Happy Clients",
                    Icon = "meditation"
                }
            };
        }

        public static AboutInfo[] GetAboutInfo()
        {
            return new AboutInfo[]
            {
                new AboutInfo()
                {
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas omnis nam molestias minus ipsa, placeat!",
                    Title = "Shower Services",
                    Icon = "spa-towel"
                },
                new AboutInfo()
                {
                    Description = "Facere aliquam itaque quia recusandae, corporis fugit fugiat eaque, accusamus officiis reprehenderit.",
                    Title = "Foot Treatments",
                    Icon = "spa-sandals"
                },
                new AboutInfo()
                {
                    Description = "Velit id facilis odit aliquid laudantium. Tempore, sequi. Harum nesciunt, magni aperiam est?",
                    Title = "Internal Beautification",
                    Icon = "spa-cup-flower"
                },
                new AboutInfo()
                {
                    Description = "Voluptatum distinctio laboriosam, excepturi delectus nam fugit obcaecati reiciendis neque iste!",
                    Title = "Yoga & Meditation",
                    Icon = "spa-meditation"
                },
                new AboutInfo()
                {
                    Description = "Quis, tenetur. Nam explicabo modi pariatur, blanditiis distinctio sapiente fugiat accusantium.",
                    Title = "Hair Dressing",
                    Icon = "spa-comb"
                },
                new AboutInfo()
                {
                    Description = "Veniam atque corporis commodi. Quidem odit, necessitatibus quo tenetur! Harum similique illo eligendi!",
                    Title = "Herbal Pedicure",
                    Icon = "spa-flowers-feet"
                }
            };
        }
        public static string[] GetTabNavs()
        {
            return new string[] { "Spa Therapy", "Beauty Facial", "Body Wrap", "Body Scrubs" };
        }
    }
}
