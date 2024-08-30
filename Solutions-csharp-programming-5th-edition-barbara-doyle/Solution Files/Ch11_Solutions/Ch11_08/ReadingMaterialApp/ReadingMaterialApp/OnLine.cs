/* OnLine.cs   
* This class extends ReadingMaterial
* to provide additional attributes for
* online reading resources. 
*/

using System;

namespace ReadingMaterialApp
{
    class OnLine: ReadingMaterial, IPrintable
    {
        private string url;

        public OnLine()
                : base()
        {
        }

        public OnLine(string theTitle)
                : base(theTitle)
        {
        }

        public OnLine(string theUrl, string theTitle)
                : base(theTitle)
        {
            url = theUrl;
        }

        public string Url
            {
                get
                {
                    return url;
                }
                set
                {
                    url = value;
                }
            }

            public string GetHardCopyPublicationDetails()
            {
                return "Printable PDF version";
            }


            public override string ToString()
            {
                return "Title: " + title +
                    "\nURL: " + url +
                    "\nHardcopy Available: " + GetHardCopyPublicationDetails();
            }
        }
    }
