// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace GoldenCityShop.Controllers
{
    public partial class CommentController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CommentController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ProductComments()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ProductComments);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ReplyComment()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ReplyComment);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CommentController Actions { get { return MVC.Comment; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Comment";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Comment";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string ProductComments = "ProductComments";
            public readonly string ReplyComment = "ReplyComment";
            public readonly string AddComment = "AddComment";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string ProductComments = "ProductComments";
            public const string ReplyComment = "ReplyComment";
            public const string AddComment = "AddComment";
        }


        static readonly ActionParamsClass_ProductComments s_params_ProductComments = new ActionParamsClass_ProductComments();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ProductComments ProductCommentsParams { get { return s_params_ProductComments; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ProductComments
        {
            public readonly string productId = "productId";
        }
        static readonly ActionParamsClass_ReplyComment s_params_ReplyComment = new ActionParamsClass_ReplyComment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ReplyComment ReplyCommentParams { get { return s_params_ReplyComment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ReplyComment
        {
            public readonly string productId = "productId";
            public readonly string commentId = "commentId";
        }
        static readonly ActionParamsClass_AddComment s_params_AddComment = new ActionParamsClass_AddComment();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddComment AddCommentParams { get { return s_params_AddComment; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddComment
        {
            public readonly string productId = "productId";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _AddComment = "_AddComment";
                public readonly string _CommentsPartial = "_CommentsPartial";
                public readonly string _ReplyToComment = "_ReplyToComment";
            }
            public readonly string _AddComment = "~/Views/Comment/_AddComment.cshtml";
            public readonly string _CommentsPartial = "~/Views/Comment/_CommentsPartial.cshtml";
            public readonly string _ReplyToComment = "~/Views/Comment/_ReplyToComment.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CommentController : GoldenCityShop.Controllers.CommentController
    {
        public T4MVC_CommentController() : base(Dummy.Instance) { }

        [NonAction]
        partial void ProductCommentsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long? productId);

        [NonAction]
        public override System.Web.Mvc.ActionResult ProductComments(long? productId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ProductComments);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "productId", productId);
            ProductCommentsOverride(callInfo, productId);
            return callInfo;
        }

        [NonAction]
        partial void ReplyCommentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long? productId, long? commentId);

        [NonAction]
        public override System.Web.Mvc.ActionResult ReplyComment(long? productId, long? commentId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ReplyComment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "productId", productId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "commentId", commentId);
            ReplyCommentOverride(callInfo, productId, commentId);
            return callInfo;
        }

        [NonAction]
        partial void AddCommentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, long? productId);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddComment(long? productId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddComment);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "productId", productId);
            AddCommentOverride(callInfo, productId);
            return callInfo;
        }

        [NonAction]
        partial void AddCommentOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddComment()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddComment);
            AddCommentOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
