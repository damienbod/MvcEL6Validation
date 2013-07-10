using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.Practices.EnterpriseLibrary.Validation;

public class EnterpriseLibraryValidatorWrapper : ModelValidator
{
    private Validator _validator;

    public EnterpriseLibraryValidatorWrapper(ModelMetadata metadata, ControllerContext context, Validator validator)
        : base(metadata, context)
    {
        _validator = validator;
    }

    public override IEnumerable<ModelValidationResult> Validate(object container)
    {
        return ConvertResults(_validator.Validate(Metadata.Model));
    }

    private IEnumerable<ModelValidationResult> ConvertResults(IEnumerable<ValidationResult> validationResults)
    {
        if (validationResults != null)
        {
            foreach (ValidationResult validationResult in validationResults)
            {
                if (validationResult.NestedValidationResults != null)
                {
                    foreach (ModelValidationResult result in ConvertResults(validationResult.NestedValidationResults))
                    {
                        yield return result;
                    }
                }

                yield return new ModelValidationResult
                    {
                        Message = validationResult.Message,
                        MemberName = validationResult.Key
                    };
            }
        }
    }
}