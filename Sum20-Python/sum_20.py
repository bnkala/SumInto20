def get_input():
    return input("Enter 3 digits that sum up 20: ")

def is_input_valid(num):
    if len(num) != 3:
        print("Invalid Input! Input should only have 3 digits")
        return False
    
    if not num.isdigit():
        print("Invalid Input! Input should only have digits")
        return False
    
    return True

def total_20(num):
    total = 0
    for x in num:
        total += int(x)

    return total

def check_20_or_not(total):
    output= ""
    print(str(total))
    if total == 20:
        output = "The numbers sum up 20"
    else:
        output = "The numbers don't sum up 20"
    return output

def display():
    num = get_input()

    while not is_input_valid(num):
        num = get_input()
    
    total = total_20(num)
    print(check_20_or_not(total))

if __name__ == "__main__":
    display()