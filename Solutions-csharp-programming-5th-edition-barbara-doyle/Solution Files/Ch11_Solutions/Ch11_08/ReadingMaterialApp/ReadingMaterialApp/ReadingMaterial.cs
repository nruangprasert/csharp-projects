/* ReadingMaterial.cs   
 * This class is an abstract base class
 * which includes common characteristics found
 * with reading material such as author, title
 * publisher, and publication date.
 */
using System;

namespace ReadingMaterialApp
{
    public abstract class ReadingMaterial
    {
        protected string authorFirstName;
        protected string authorLastName;
        protected string title;
        protected string materialType;
        protected string publisher;
        protected string publicationDate;

        public ReadingMaterial()
        {
        }

        public ReadingMaterial(string first, string last, string theTitle,
                                    string theTypeOfMaterial, string thePublisher, string thePublicationDate)
        {
            authorFirstName = first;
            authorLastName = last;
            title = theTitle;
            materialType = theTypeOfMaterial;
            publisher = thePublisher;
            publicationDate = thePublicationDate;
        }

        public ReadingMaterial(string first, string last, string publicationTitle, 
                                string thePublisher, string thePublicationDate)
        {
            authorFirstName = first;
            authorLastName = last;
            title = publicationTitle;
            publisher = thePublisher;
            publicationDate = thePublicationDate;
        }

        public ReadingMaterial(string theTitle)
        {
            title = theTitle;
        }

        public string GetPublicationDate()
        {
            return publicationDate;
        }

 
        public string AuthorFirstName
        {
            get
            {
                return authorFirstName;
            }
            set
            {
                authorFirstName = value;
            }
        }

        public string AuthorLastName
        {
            get
            {
                return authorLastName;
            }
            set
            {
                authorLastName = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string MaterialType
        {
            get
            {
                return materialType;
            }
            set
            {
                materialType = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }

        public string PublicationDate
        {
            get
            {
                return publicationDate;
            }
            set
            {
                publicationDate = value;
            }
        }

        public override string ToString()
        {
            return "Title: " + title +
                "\nAuthor: " + authorFirstName + " " + authorLastName +
                "\nPublisher: " + publisher +
                "\nPublication Date: " + publicationDate;
        }

    }
}
