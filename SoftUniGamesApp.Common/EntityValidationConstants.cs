using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniGamesApp.Common
{
    public static class EntityValidationConstants
    {
        public static class Game
        {
            public const int TitleMinLength = 3;
            public const int TitleMaxLength = 50;
            public const int GenreMinLength = 3;
            public const int GenreMaxLength = 20;
            public const int StudioMinLength = 5;
            public const int StudioMaxLength = 50;
            public const int DescriptionMinLength = 20;
            public const int DescriptionMaxLength = 500;
            public const string PriceMinValue = "0.01m";
            public const string PriceMaxValue = "200m";
        }

        public static class Bundle
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;
            public const string PriceMinValue = "0.01m";
            public const string PriceMaxValue = "4000m";
        }

        public static class Comment
        {
            public const int MessageMinLength = 5;
            public const int MessageMaxLength = 200;
        }
    }
}
