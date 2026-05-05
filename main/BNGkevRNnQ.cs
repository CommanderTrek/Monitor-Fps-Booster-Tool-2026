using System;
using System.Collections.Generic;
using System.Text;
public static class StringUtils{
public static string Reverse(string input){
char[] charArray = input.ToCharArray();
Array.Reverse(charArray);
return new string(charArray);
}
public static string ToCamelCase(string input){
StringBuilder result = new StringBuilder();
bool isNextUpper = false;
foreach(char c in input){
if(c == ' '){
isNextUpper = true;
continue;
}
if(isNextUpper){
result.Append(char.ToUpper(c));
isNextUpper = false;
}else{
result.Append(char.ToLower(c));
}
}
return result.ToString();
}
public static string ToSnakeCase(string input){
StringBuilder result = new StringBuilder();
foreach(char c in input){
if(char.IsUpper(c) && result.Length > 0){
result.Append('_');
}
result.Append(char.ToLower(c));
}
return result.ToString();
}
public static List<string> SplitByLength(string input, int length){
List<string> result = new List<string>();
for(int i = 0; i < input.Length; i += length){
if(i + length < input.Length){
result.Add(input.Substring(i, length));
}else{
result.Add(input.Substring(i));
}
}
return result;
}
public static string JoinWithSeparator(List<string> items, string separator){
return string.Join(separator, items);
}
public static string RemoveWhitespace(string input){
return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
}
public static string Truncate(string input, int maxLength){
if(input.Length <= maxLength){
return input;
}
return input.Substring(0, maxLength) + "...";
}}
