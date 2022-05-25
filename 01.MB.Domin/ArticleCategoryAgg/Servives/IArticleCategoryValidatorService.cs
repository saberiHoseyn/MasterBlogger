namespace _01.MB.Domin.ArticleCategoryAgg.Servives
{
    public interface IArticleCategoryValidatorService
    {
        void CheckThatThisRecordAlreadyExists(string title);
    }
}
