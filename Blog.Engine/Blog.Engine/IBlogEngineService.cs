﻿using Blog.Engine.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Engine
{
    interface IBlogEngineService
    {
        List<Posts> get();
        Result post(int postsId, string comment);
        ProcessPostsResponse postprocess(string actionProcess, Posts posts, string author);
        ProcessPostsResponse postprocesseditor(string actionProcess, Posts posts, string author);
    }
}