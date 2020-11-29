using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Person
{
    public class PointZNO
    {
        protected int UkrainianLanguageAndLiterature;
        protected int HistoryOfUkraine;
        protected int Maths;
        protected int Biology;
        protected int Geography;
        protected int Physics;
        protected int Chemistry;
        protected int English;
        protected int Spanish;
        protected int German;
        protected int French;

        public PointZNO(int ukrainianLanguageAndLiterature)
        {
            SetUkrainianLanguageAndLiterature(ukrainianLanguageAndLiterature);
            SetMaths(0);
            SetPhysics(0);
            SetHistoryOfUkraine(0);
            SetBiology(0);
            SetGeography(0);
            SetChemistry(0);
            SetEnglish(0);
            SetSpanish(0);
            SetGerman(0);
            SetFrench(0);
        }

        public PointZNO(int ukrainianLanguageAndLiterature, int maths, int physics)
        {
            SetUkrainianLanguageAndLiterature(ukrainianLanguageAndLiterature);
            SetMaths(maths);
            SetPhysics(physics);
            SetHistoryOfUkraine(0);
            SetBiology(0);
            SetGeography(0);
            SetChemistry(0);
            SetEnglish(0);
            SetSpanish(0);
            SetGerman(0);
            SetFrench(0);
        }

        public PointZNO(int ukrainianLanguageAndLiterature, int historyOfUkraine, int geography, int english)
        {
            SetUkrainianLanguageAndLiterature(ukrainianLanguageAndLiterature);
            SetHistoryOfUkraine(historyOfUkraine);
            SetGeography(geography);
            SetEnglish(english);
            SetBiology(0);
            SetMaths(0);
            SetChemistry(0);
            SetPhysics(0);
            SetSpanish(0);
            SetGerman(0);
            SetFrench(0);
        }

        public void SetUkrainianLanguageAndLiterature(int ukrainianLanguageAndLiterature)
        {
            if (ukrainianLanguageAndLiterature >= 100 && ukrainianLanguageAndLiterature <= 200)
                UkrainianLanguageAndLiterature = ukrainianLanguageAndLiterature;
            else UkrainianLanguageAndLiterature = 0;
        }

        public void SetHistoryOfUkraine(int historyOfUkraine)
        {
            if (historyOfUkraine >= 100 && historyOfUkraine <= 200)
                HistoryOfUkraine = historyOfUkraine;
            else HistoryOfUkraine = 0;
        }

        public void SetMaths(int maths)
        {
            if (maths >= 100 && maths <= 200)
                Maths = maths;
            else Maths = 0;
        }

        public void SetBiology(int biology)
        {
            if (biology >= 100 && biology <= 200)
                Biology = biology;
            else Biology = 0;
        }

        public void SetGeography(int geography)
        {
            if (geography >= 100 && geography <= 200)
                Geography = geography;
            else Geography = 0;
        }

        public void SetPhysics(int physics)
        {
            if (physics >= 100 && physics <= 200)
                Physics = physics;
            else Physics = 0;
        }

        public void SetChemistry(int chemistry)
        {
            if (chemistry >= 100 && chemistry <= 200)
                Chemistry = chemistry;
            else Chemistry = 0;
        }

        public void SetEnglish(int english)
        {
            if (english >= 100 && english <= 200)
                English = english;
            else English = 0;
        }

        public void SetSpanish(int spanish)
        {
            if (spanish >= 100 && spanish <= 200)
                Spanish = spanish;
            else Spanish = 0;
        }

        public void SetGerman(int german)
        {
            if (german >= 100 && german <= 200)
                German = german;
            else German = 0;
        }

        public void SetFrench(int french)
        {
            if (french >= 100 && french <= 200)
                French = french;
            else French = 0;
        }

        public int GetUkrainianLanguageAndLiterature()
        {
            return UkrainianLanguageAndLiterature;
        }

        public int GetHistoryOfUkraine()
        {
            return HistoryOfUkraine;
        }

        public int GetMaths()
        {
            return Maths;
        }

        public int GetBiology()
        {
            return Biology;
        }

        public int GetGeography()
        {
            return Geography;
        }

        public int GetPhysics()
        {
            return Physics;
        }

        public int GetChemistry()
        {
            return Chemistry;
        }

        public int GetEnglish()
        {
            return English;
        }

        public int GetSpanish()
        {
            return Spanish;
        }

        public int GetGerman()
        {
            return German;
        }

        public int GetFrench()
        {
            return French;
        }

        public string GetInfo()
        {
            string result = "";
            if (UkrainianLanguageAndLiterature >= 100)
                result += $"Українська мова і література: {UkrainianLanguageAndLiterature}\n";
            if (HistoryOfUkraine >= 100)
                result += $"Історія України: {HistoryOfUkraine}\n";
            if (Maths >= 100)
                result += $"Математика: {Maths}\n";
            if (Biology >= 100)
                result += $"Біологія: {Biology}\n";
            if (Geography >= 100)
                result += $"Географія: {Geography}\n";
            if (Physics >= 100)
                result += $"Фізика: {Physics}\n";
            if (Chemistry >= 100)
                result += $"Хімія: {Chemistry}\n";
            if (English >= 100)
                result += $"Англійська мова: {English}\n";
            if (Spanish >= 100)
                result += $"Іспанська мова: {Spanish}\n";
            if (German >= 100)
                result += $"Німецька мова: {German}\n";
            if (French >= 100)
                result += $"Французька мова: {French}\n";

            return result;
        }
    }
}
