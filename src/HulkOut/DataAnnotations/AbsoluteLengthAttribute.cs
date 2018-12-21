using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace HulkOut.DataAnnotations
{
  /// <summary>
  ///   Specifies the absolute length of array/string data allowed in a property.
  /// </summary>
  [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
  public class AbsoluteLengthAttribute : ValidationAttribute
  {
    private const int AbsoluteAllowableLength = -1;

    /// <summary>
    ///   Initializes a new instance of the <see cref="T:HulkOut.DataAnnotations.AbsoluteLengthAttribute" /> class.
    /// </summary>
    /// <param name="length">
    ///   The absolute allowable length of array/string data.
    ///   Value must be greater than zero.
    /// </param>
    public AbsoluteLengthAttribute(int length)
      : base(() => DefaultErrorMessageString)
    {
      Length = length;
    }

    /// <summary>
    ///   Initializes a new instance of the <see cref="T:HulkOut.DataAnnotations.AbsoluteLengthAttribute" /> class.
    ///   The absolute allowable length supported by the database will be used.
    /// </summary>
    public AbsoluteLengthAttribute()
      : base(() => DefaultErrorMessageString)
    {
      Length = AbsoluteAllowableLength;
    }

    /// <summary>
    ///   Gets the absolute allowable length of the array/string data.
    /// </summary>
    public int Length { get; }

    private static string DefaultErrorMessageString =>
      "The field {0} must be a string or array type with an absolute length of '{1}'.";

    /// <summary>
    ///   Determines whether a specified object is valid. (Overrides
    ///   <see cref="M:System.ComponentModel.DataAnnotations.ValidationAttribute.IsValid(System.Object)" />)
    /// </summary>
    /// <remarks>
    ///   This method returns <c>true</c> if the <paramref name="value" /> is null.
    ///   It is assumed the <see cref="T:System.ComponentModel.DataAnnotations.RequiredAttribute" /> is used if the value may
    ///   not be null.
    /// </remarks>
    /// <param name="value">The object to validate.</param>
    /// <returns><c>true</c> if the value is null or equal to the specified absolute length, otherwise <c>false</c></returns>
    /// <exception cref="T:System.InvalidOperationException">Length is zero or less than negative one.</exception>
    public override bool IsValid(object value)
    {
      // Check the lengths for legality
      EnsureLegalLengths();

      int length;
      // Automatically pass if value is null. RequiredAttribute should be used to assert a value is not null.
      if (value == null)
      {
        return true;
      }

      var str = value as string;
      length = str?.Length ?? ((Array) value).Length;

      return AbsoluteAllowableLength == Length || length == Length;
    }

    /// <summary>
    ///   Applies formatting to a specified error message. (Overrides
    ///   <see cref="M:System.ComponentModel.DataAnnotations.ValidationAttribute.FormatErrorMessage(System.String)" />)
    /// </summary>
    /// <param name="name">The name to include in the formatted string.</param>
    /// <returns>A localized string to describe the maximum acceptable length.</returns>
    public override string FormatErrorMessage(string name)
    {
      // An error occurred, so we know the value is greater than the maximum if it was specified
      return string.Format(CultureInfo.CurrentCulture, ErrorMessageString, name, Length);
    }

    /// <summary>
    ///   Checks that Length has a legal value.
    /// </summary>
    /// <exception cref="InvalidOperationException">Length is zero or less than negative one.</exception>
    private void EnsureLegalLengths()
    {
      if (Length == 0 || Length < -1)
      {
        throw new InvalidOperationException(
          "AbsoluteLengthAttribute must have a Length value that is greater than zero. Use AbsoluteLength() without parameters to indicate that the string or array can have the absolute allowable length.");
      }
    }
  }
}