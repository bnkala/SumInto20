'''
The user is asked to enter exactly 3 digits as input
returns: 3-digit input
'''
def get_input():
    return input("Enter 3 digits that sum up 20: ")


'''
The input is validated to see the actual length is 3 and is numerical
returns: true if the input is valid else false if one condition is false
'''
def is_input_valid(num):
    if len(num) != 3:
        print("Invalid Input! Input should only have 3 digits")
        return False
    
    if not num.isdigit():
        print("Invalid Input! Input should only have digits")
        return False
    
    return True


'''
The input is iterated to determine the total sum of 3 digits
returns: total of 3 digits
'''
def total_20(num):
    total = 0
    for x in num:
        total += int(x)

    return total


'''
The result is validated to see whether it is actually 20 or not
returns: a statement whether the input sum up 20 or not
'''
def check_20_or_not(num,total):
    output= ""
    print("Sum: " + str(total))
    if total == 20:
        output = num + " sum up 20"
    else:
        output = num + " don't sum up 20"
    return output


'''
the function calls the functions and prints the actual output
'''
def display():
    num = get_input()

    while not is_input_valid(num):
        num = get_input()
    
    total = total_20(num)
    print(check_20_or_not(num,total))


if __name__ == "__main__":
    display()