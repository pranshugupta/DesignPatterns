using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryLibrary.Products;

namespace FactoryLibrary.Factory
{
    public abstract class Document
    {
        public List<Page> Pages { get; private set; }
        public Document()
        {
            Pages = new List<Page>();
            CreateDocument();
        }
        public abstract void CreateDocument();
    }

    public class Resume : Document
    {
        public override void CreateDocument()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    public class Report : Document
    {
        public override void CreateDocument()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
