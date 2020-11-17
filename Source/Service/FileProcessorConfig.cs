﻿using Glasswall.Core.Engine.Common.PolicyConfig;
using Service.StoreMessages.Enums;
using System;

namespace Service
{
    public class FileProcessorConfig : IFileProcessorConfig
    {
        public string FileId { get; set; }
        public string InputPath { get; set; }
        public string OutputPath { get; set; }
        public string AmqpURL { get; set; }
        public string ReplyTo { get; set; }
        public TimeSpan ProcessingTimeoutDuration { get; set; }
        public Guid PolicyId { get; set; }
        public ContentManagementFlags ContentManagementFlags { get; set; }
        public NcfsOption UnprocessableFileTypeAction { get; set; }
        public NcfsOption GlasswallBlockedFilesAction { get; set; }
        public string NcfsRoutingUrl { get; set; }
    }
}