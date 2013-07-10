using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.EnterpriseLibrary.Validation;
  
public class EnterpriseLibraryValidatorProvider : ModelValidatorProvider {
  public override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context) {
    Validator validator = ValidationFactory.CreateValidator(metadata.ModelType);
  
    if (validator != null) {
      yield return new EnterpriseLibraryValidatorWrapper(metadata, context, validator);
    }
  }
}