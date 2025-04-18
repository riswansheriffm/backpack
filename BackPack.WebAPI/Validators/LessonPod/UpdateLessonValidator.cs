﻿using BackPack.Library.Requests.LessonPod;
using FluentValidation;

namespace BackPack.WebAPI.Validators.LessonPod
{
    public class UpdateLessonValidator : AbstractValidator<UpdateLessonRequest>
    {
        public UpdateLessonValidator() 
        {
            RuleFor(request => request.SubjectID).NotNull().NotEmpty();
            RuleFor(request => request.ChapterID).NotNull().NotEmpty();
            RuleFor(request => request.LessonName).NotNull().NotEmpty().Length(1, 100);
            RuleFor(request => request.ActivityBy).NotNull();
        }
    }
}
 