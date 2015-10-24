using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DirectFromChef.Models
{
    public class ChefDetails
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ChefDetails() {
            _chefKinds = db.ChefKinds.ToList();
            NoOfServices = db.NoOfServices.ToList();
            Cuisines = db.Cuisines.ToList();
            CookingTimes = db.CookingTimes.ToList();
            CookingDays = new List<CookingDays>(7);
            CookingDays.Add(new CookingDays
            {
                Id = 1,
                Name = "Monday",
                Checked = false
            });
            CookingDays.Add(new CookingDays
            {
                Id = 2,
                Name = "Tuesday",
                Checked = false
            });
            CookingDays.Add(new CookingDays
            {
                Id = 3,
                Name = "Wednesday",
                Checked = false
            });
            CookingDays.Add(new CookingDays
            {
                Id = 4,
                Name = "Thrusday",
                Checked = false
            });
            CookingDays.Add(new CookingDays
            {
                Id = 5,
                Name = "Friday",
                Checked = false
            });
            CookingDays.Add(new CookingDays
            {
                Id = 6,
                Name = "Saturday",
                Checked = false
            });
            CookingDays.Add(new CookingDays
            {
                Id = 7,
                Name = "Sunday",
                Checked = false
            });
            //NoOfServices.Add(1, "1 - 5");
            //NoOfServices.Add(2, "5 - 10");
            //NoOfServices.Add(3, "10 - 20");
            //NoOfServices.Add(4, "20 - 30");
            //NoOfServices.Add(5, "30 - 40");
            //NoOfServices.Add(6, "40 - 50");
            //NoOfServices.Add(7, "More than 50");
        }
        public int Id { get; set; }
        public string AspNetUsersId { get; set; }
        public virtual ApplicationUser ApplicationUserChef { get; set; }

        [Required]
        [Display(Name = "Describe Experience")]
        public string ChefExperience { get; set; }

        [Required]
        [Display(Name = "Kitchen Address")]
        public string KitchenAddress { get; set; }

        private readonly List<ChefKind> _chefKinds;

        [Required]
        [Display(Name="You Are")]
        public int ChefKindID { get; set; }

        public IEnumerable<SelectListItem> ChefKindItems { get { 
            return new SelectList(_chefKinds, "Id", "Name");
        } }

        private readonly  List<NoOfServices> NoOfServices;
        
        [Required]
        [Display(Name="How Many People Can You Serve In a Day?")]
        public int NoOfServicesID { get; set; }

        public IEnumerable<SelectListItem> NoOfServicesItems {
            get { return new SelectList(NoOfServices, "Id", "Name"); }
        }

        [Required]
        [Display(Name = "What times would you like to cook")]
        public string CookingTimings { get; set; }

        public virtual List<CookingTime> CookingTimes {get; set;}

        [Required]
        [Display(Name="What Cuisines whould you like to prepare ?")]    
        public string AllCuisines { get; set; }

        public virtual List<CuisinesModel> Cuisines { get; set; }

        [Required]
        [Display(Name = "Which days of the week can you cook?")]    
        public string CookingDaysSelected { get; set; }
        public virtual List<CookingDays> CookingDays { get; set; }


        [Required]
        [Display(Name = "Kitchen Location")]
        public string KitchenLocation { get; set; }

        public string LatLng { get; set; }

        
        public string ImgUrl { get; set; }

        public int Rating { get; set; }
    }

}
