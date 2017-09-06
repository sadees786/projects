namespace EmailService
{
    public interface IEmailValueParser
    {
        /// <summary>
        /// Create mail message from <paramref name="EmailTemplate"/>.
        /// </summary>
        string CreateMessage(string emailTemplate, params object[] args);
     }
}