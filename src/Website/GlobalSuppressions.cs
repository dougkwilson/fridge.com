// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Potential Code Quality Issues", "RECS0022:A catch clause that catches System.Exception and has an empty body", Justification = "The exception doesn't matter; we just use the fall-back.", Scope = "member", Target = "~M:Website.StringExtensions.CreateEmailValidationRegex~System.Text.RegularExpressions.Regex")]
