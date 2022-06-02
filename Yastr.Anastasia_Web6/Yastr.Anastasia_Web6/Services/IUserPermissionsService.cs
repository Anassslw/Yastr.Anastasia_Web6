using System;
using Yastr.Anastasia_Web6.Models;

namespace Yastr.Anastasia_Web6.Services
{
    public interface IUserPermissionsService
    {
        Boolean CanEditPost(Post post);

        Boolean CanEditPostComment(PostComment postComment);
    }
}