namespace ProGet.Net.UniversalFeed.Models
{
    public class Package
    {
        public string Group { get; set; } // A string of zero to fifty characters: numbers(0-9), upper- and lower-case letters(a-Z), dashes(-), periods(.), forward-slashes(/), and underscores(_); may not start or end with a forward-slash; if not specified, the group name will be considered an empty string
        public string Name { get; set; } // A string of one to fifty characters: numbers(0-9), upper- and lower-case letters(a-Z), dashes(-), periods(.), and underscores(_)
        public string Version { get; set; } // A string representing a Semantic Version; this is a three-part, dot- specification.
        public string Title { get; set; } // A string of no more than fifty characters
        public string Icon { get; set; } // A string of an absolute url pointing to an image to be displayed in the ProGet UI(at both 64px and 128px); if  package:// is used as the protocol, ProGet will search within the package and serve that image instead
        public string Description { get; set; } // A string containing any number of charters; these will be formatted as Markdown in the ProGet UI
        public string[] Dependencies { get; set; } // An array of strings, each consisting of a package identification string; this string is formatted as follows:
            //«group»:«package-name»
            //«group»/«package-name»:«version»
            //When the version is not specified, the latest is used.
    }
}
