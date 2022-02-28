﻿namespace Mango.Web.Models;

public class ApiRequest
{
    public SD.ApiType ApiType { get; set; } = SD.ApiType.GET;
    public string Url { get; set; } = string.Empty;
    public object Data { get; set; }
    public string AccessToken { get; set; } = string.Empty;
}