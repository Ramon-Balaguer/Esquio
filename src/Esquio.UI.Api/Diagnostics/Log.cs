﻿using Microsoft.Extensions.Logging;
using System;

namespace Esquio.UI.Api.Diagnostics
{
    static class Log
    {
        public static void ApiKeyAlreadyExist(ILogger logger, string apiKeyName)
        {
            _apiKeyAlreadyExist(logger, apiKeyName, null);
        }

        public static void ApiKeyNotExist(ILogger logger, string apiKeyId)
        {
            _apiKeyNotExist(logger, apiKeyId, null);
        }
        public static void FeatureNameAlreadyExist(ILogger logger, string featureName)
        {
            _featureNameAlreadyExist(logger, featureName, null);
        }

        public static void ProductAlreadyExist(ILogger logger, string productName)
        {
            _productAlreadyExist(logger, productName, null);
        }

        public static void ProductNotExist(ILogger logger, string productId)
        {
            _productNotExist(logger, productId, null);
        }

        public static void FeatureNotExist(ILogger logger, string featureId)
        {
            _featureNotExist(logger, featureId, null);
        }

        public static void ToggleNotExist(ILogger logger, string toggleId)
        {
            _toggleNotExist(logger, toggleId, null);
        }

        public static void FeatureTagAlreadyExist(ILogger logger, string featureId, string tag)
        {
            _featureTagAlreadyExist(logger, featureId, tag, null);
        }
        public static void FeatureTagNotExist(ILogger logger, string featureId, string tag)
        {
            _featureTagNotExist(logger, featureId, tag, null);
        }

        public static void ToggleTypeAlreadyExist(ILogger logger, string toggleType, string featureName)
        {
            _toggleAlreadyExist(logger, toggleType, featureName, null);
        }

        public static void ExecutingCommand(ILogger logger, string commandName)
        {
            _executingCommand(logger, commandName, null);
        }
        public static void ExecutedCommand(ILogger logger, string commandName)
        {
            _executedCommand(logger, commandName, null);
        }

        private static readonly Action<ILogger, string, Exception> _apiKeyAlreadyExist = LoggerMessage.Define<string>(
            LogLevel.Warning,
            EventIds.ApiKeyAlreadyExist,
            "The ApiKey with name {apiKeyName} already exist in the store and can't be created.");
        private static readonly Action<ILogger, string, Exception> _productAlreadyExist = LoggerMessage.Define<string>(
           LogLevel.Warning,
           EventIds.ProductAlreadyExist,
           "The product with name {productName} already exist in the store and can't be created.");
        private static readonly Action<ILogger, string, Exception> _featureNameAlreadyExist = LoggerMessage.Define<string>(
            LogLevel.Warning,
            EventIds.FeatureAlreadyExist,
            "A feature with name {featureName} already exist in the store and can't be created.");
        private static readonly Action<ILogger, string, Exception> _apiKeyNotExist = LoggerMessage.Define<string>(
            LogLevel.Warning,
            EventIds.ApiKeyNotExist,
            "The ApiKey with identifier {apiKeyId} does not exist in database and can't be deleted.");
        private static readonly Action<ILogger, string, Exception> _productNotExist = LoggerMessage.Define<string>(
            LogLevel.Warning,
            EventIds.ProductNotExist,
            "The product with identifier {productId} does not exist in database.");
        private static readonly Action<ILogger, string, Exception> _featureNotExist = LoggerMessage.Define<string>(
           LogLevel.Warning,
           EventIds.FeatureNotExist,
           "The feature with identifier {featureId} does not exist in database.");
        private static readonly Action<ILogger, string, Exception> _toggleNotExist = LoggerMessage.Define<string>(
          LogLevel.Warning,
          EventIds.ToggleNotExist,
          "The toggle with identifier {toggleId} does not exist in database.");
        private static readonly Action<ILogger, string, string, Exception> _toggleAlreadyExist = LoggerMessage.Define<string, string>(
           LogLevel.Warning,
           EventIds.ToggleAlreadyExist,
           "A toggle with type {toggleType} already exist on feature {featureName} and can't be added.");
        private static readonly Action<ILogger, string, string, Exception> _featureTagNotExist = LoggerMessage.Define<string, string>(
          LogLevel.Warning,
          EventIds.FeatureTagNotExist,
          "The feature association between feature {featureId} and tag {tag} does not exist.");
        private static readonly Action<ILogger, string, string, Exception> _featureTagAlreadyExist = LoggerMessage.Define<string, string>(
          LogLevel.Warning,
          EventIds.FeatureAlreadyExist,
          "The feature with id {featureId} already have association with tag {tag}.");
        private static readonly Action<ILogger, string, Exception> _executingCommand = LoggerMessage.Define<string>(
            LogLevel.Debug,
            EventIds.ExecutingCommand,
            "Executing command with name {commandName}.");
        private static readonly Action<ILogger, string, Exception> _executedCommand = LoggerMessage.Define<string>(
            LogLevel.Debug,
            EventIds.ExecutedCommand,
            "Executed  command with name {commandName}.");
    }
}
