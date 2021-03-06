﻿using System.Threading.Tasks;
using Lykke.Job.Messages.Core.Services.Sms;
using Lykke.Job.Messages.Core.Services.Templates;

namespace Lykke.Job.Messages.Services.Sms
{
    public class SmsTextGenerator : ISmsTextGenerator
    {
        private readonly ITemplateGenerator _templateGenerator;

        public SmsTextGenerator(ITemplateGenerator templateGenerator)
        {
            _templateGenerator = templateGenerator;
        }

        public async Task<string> GenerateConfirmSmsText(string confirmationCode)
        {
            return $"Lykke Confirmation code: {confirmationCode}";
        }
    }
}