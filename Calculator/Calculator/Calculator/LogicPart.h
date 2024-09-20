#pragma warning(disable : 4996)
#pragma warning(disable : 4244)
#ifndef LOGICPART
#include <iostream>
#include <cstdlib>
#include <cctype>
#include <cstring>
#include <math.h>
using namespace std;
 
/*
addition (+),
subtraction (−),
multiplication (*),
division (/),
modulo (%)
the calculator also stores variables
e.g x = 2, 5 * x would equal 10
*/
 
enum types { DELIMITER = 1, VARIABLE, NUMBER, FUNCTION };
const int NUMVARS = 26;

class parser {
private:
	char *expression_ptr; // ptr to expression
    char token[256]; // holds token
    char token_type; // holds the token's type
    double vars[NUMVARS]; // holds var values
	
public:
    char errormsg[64];
// Parser constructor.
parser()
{
    int i;
    expression_ptr = NULL;
    for (i = 0; i < NUMVARS; i++)
        vars[i] = 0.0;
    errormsg[0] = '\0';
}
// Processes an assignment.
void evaluate_exp1(double &result)
{
    int slot;
    char temp_token[80];
    if (token_type == VARIABLE) 
    {
        // saves the old token
        char *t_ptr = expression_ptr;
        strcpy(temp_token, token);
        // computes the index of the variable
        slot = *token - 'A';
        get_token();
        if (*token != '=') 
        {
            expression_ptr = t_ptr; // returns the current token
            strcpy(token, temp_token); // restores the old token
            token_type = VARIABLE;
        }
        else {
            get_token(); // gets the next part of exp
            evaluate_exp2(result);
            vars[slot] = result;
            return;
        }
    }
    evaluate_exp2(result);
}
// Entry point of the parser.
double evaluate_exp(char *exp)
{
    errormsg[0] = '\0';
    double result;
    expression_ptr = exp;
    get_token();
    if (!*token) 
    {
        strcpy(errormsg, "No Expression");
        return (double)0;
    }
    evaluate_exp1(result);
    if (*token) // last token must be null
        strcpy(errormsg, "Syntax Error, perhaps you forgot\n to add * before brackets");
    return result;
}

// Multiplies or divides
void evaluate_exp3(double &result)
{
    register char op;
    double temp;
    evaluate_exp4(result);
    while ((op = *token) == '*' || op == '/') 
    {
        get_token();
        evaluate_exp4(temp);
        switch (op) 
        {
        case '*':
            result = result * temp;
            break;
        case '/':
            result = result / temp;
            break;
        }
    }
}
// Adds or subtracts
void evaluate_exp2(double &result)
{
    register char op;
    double temp;
    evaluate_exp3(result);
    while ((op = *token) == '+' || op == '-')
    {
        get_token();
        evaluate_exp3(temp);
        switch (op) 
        {
        case '-':
            result = result - temp;
            break;
        case '+':
            result = result + temp;
            break;
        }
    }
}
// Modulo
void evaluate_exp4(double &result)
{
        double temp;
        evaluate_exp5(result);
        while (*token == '%')
        {
            get_token();
            evaluate_exp5(temp);
            result = (int)roundf(result) % (int)roundf(temp);
        }
}
// Evaluates a unary + or -.
void evaluate_exp5(double &result)
{
    register char op;
    op = 0;
    if ((token_type == DELIMITER) && *token == '+' || *token == '-')
    {
        op = *token;
        get_token();
    }
    evaluate_exp6(result);
    if (op == '-')
        result = -result;
}
// Process a function, a parenthesized expression, a value or a variable
void evaluate_exp6(double &result)
{
    bool isfunc = (token_type == FUNCTION);
    char temp_token[80];
    if (isfunc)
    {
        strcpy(temp_token, token);
        get_token();
    } 
    if ((*token == '(')) 
    {
        get_token();
        evaluate_exp2(result);
        if (*token != ')')
            strcpy(errormsg, "Unbalanced Parentheses");
        if (isfunc)
        {

            if (!strcmp(temp_token, "INT"))
                result = floor(result);
            else
                strcpy(errormsg, "Unknown Function");
        }
        get_token();
    }
    else
        switch (token_type)
        {
        case VARIABLE:
            result = vars[*token - 'A'];
            get_token();
            return;
        case NUMBER:
            result = atof(token);
            get_token();
            return;
        default:
            strcpy(errormsg, "Syntax Error");
        }
}


// Obtains the next token.
void get_token()
{
    register char *temp;
    token_type = 0;
    temp = token;
    *temp = '\0';
    if (!*expression_ptr)
        return;
    while (isspace(*expression_ptr))  // skip over white space
        ++expression_ptr; 
    if (strchr("+-*/%^=()", *expression_ptr)) 
    {
        token_type = DELIMITER;
        *temp++ = *expression_ptr++;  // advances to next char
    }
    else if (isalpha(*expression_ptr)) 
    {
        while (!strchr(" +-/*%^=()\t\r", *expression_ptr) && (*expression_ptr))
            *temp++ = toupper(*expression_ptr++);
        while (isspace(*expression_ptr))  // skips over white space
            ++expression_ptr;
        token_type = (*expression_ptr == '(') ? FUNCTION : VARIABLE;
    }
    else if (isdigit(*expression_ptr) || *expression_ptr == '.')
    {
        while (!strchr(" +-/*%^=()\t\r", *expression_ptr) && (*expression_ptr))
            *temp++ = toupper(*expression_ptr++);
        token_type = NUMBER;
    }
    *temp = '\0';
    if ((token_type == VARIABLE) && (token[1]))
        strcpy(errormsg, "Only first letter of variables \n is considered");
}
};
#endif
