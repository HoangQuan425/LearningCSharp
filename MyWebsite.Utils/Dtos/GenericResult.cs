﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Utils.Dtos
{
  public class GenericResult
  {
    public GenericResult() { }

    public GenericResult(bool success)
    {
      Success = success;
    }

    public GenericResult(bool success, string message) : this(success)
    {
      Message = message;
    }

    public GenericResult(object data, bool success)
    {
      Data = data;
      Success = success;
    }

    public object Data { get; set; }

    public bool Success { get; set; }

    public string Message { get; set; }

    public object Error { get; set; }


  }
}
