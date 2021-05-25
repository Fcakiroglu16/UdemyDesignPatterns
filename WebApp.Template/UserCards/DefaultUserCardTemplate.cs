using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Template.UserCards
{
    public class DefaultUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            return string.Empty;
        }

        protected override string SetPicture()
        {
            return $"<img class='card-img-top' src='/userpictures/defaultuserpicture.png'>";
        }
    }
}