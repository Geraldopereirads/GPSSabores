namespace GPSSabores.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : MyRecipeBookException
    {
        public IList<string> ErrorsMessages { get; set; }

        public ErrorOnValidationException(IList<string> errors)
        {
            ErrorsMessages = errors;
        }
    }
}
