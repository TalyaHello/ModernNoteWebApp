using System;
using FluentValidation;

namespace Notes.Application.Notes.Querries.GetNoteDetails
{
    public class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNoteDetailsQueryValidator()
        {
            RuleFor(getNoteDetailsQuery =>
                getNoteDetailsQuery.UserId).NotEqual(Guid.Empty);
            RuleFor(getNoteDetailsQuery =>
                getNoteDetailsQuery.Id).NotEqual(Guid.Empty);
        }
    }
}
