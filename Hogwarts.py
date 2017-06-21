#Python: 2.7.13
#
#Date: 06/20/2017
#
#Author: Carrie Del Signore
#
#Purpose: To demonstrate the basic programming skills with the use of Python.
#         This is for learning purposes only, and use of all Hogwarts and
#         other creations of J.K. Rowling has been reproduced without permission.
#         Not intended for sale or distribution; simply for demonstration 

import time
from random import randint

def start(name="",house=""):
    name = welcome(name)
    
def welcome(name):
    if name == "":
        name = raw_input("Greetings young wizard! Welcome to Hogwarts School of Witchcraft and Wizardry! What is your name? ").title()
        if name !="":
            print ("\n{}, we are happy you are here. Now, it's time for you to be sorted!".format(name))
            time.sleep(1)

        hat_select(name)

           
def hat_select(name):
    stop = True
    while stop:
        house = ""
        hat_sort = raw_input("\nPlease select which attributes you value most: \n\ncourage and valor: push '1'\ntenacity and resourcefulness: push '2'\npatience and loyalty: push '3'\nintelligence and knowledge: push '4' \n")

        if hat_sort == '1':
            house = "Gryffindor"
            print ("I detect the heart of a lion! Welcome to {}!\n".format(house))
            stop = False
            
        elif hat_sort == '2':
            house = "Slytherin"
            print ("I sense the cunning of a serpent! Welcome to {}!\n".format(house))
            stop = False

        elif hat_sort == '3':
            house = "Hufflepuff"
            print ("I feel kindness coming from within! Welcome to {}!\n".format(house))
            stop = False

        elif hat_sort == '4':
            house = "Ravenclaw"
            print ("I sense your thirst for knowledge! Welcome to {}!\n".format(house))
            stop = False

        else:
            print("hmm, I can't seem to decide. Please push 1,2,3, or 4 to select your attributes...")
            
    time.sleep(2)
    class_schedule(name,house)

       
def class_schedule(name,house):
    courses = ['Transfiguration',
           'Charms',
           'Potions',
           'History of Magic',
           'Defence Against the Dark Arts',
           'Astronomy',
           'Herbology',
           'Flying']

    print ("Each house will begin with 100 points. Let's see if we can earn some points for {}!\n".format(house))
    time.sleep(2)
    print ("Ok, now that you have been sorted, let's get your class schedule: \n")
    time.sleep(2)

    for iteration in courses:
        print iteration

    print ("\n\n{}, it looks like you forgot a few items!".format(name))
    time.sleep(2)
    print ("\nLet's make a quick trip to Diagon Alley to get some supplies.")
    time.sleep(2)

    Longbottom_help(name,house)

            
def Longbottom_help(name,house):
    stop = True
    points = 100
    while stop:
        neville = raw_input("\nOh no, it looks like Neville Longbottom has accidentally gotten himself stunned. \nWill you help him? y/n:").lower()
        if neville == "y":
            print("\nYou are a good friend! Dumbledore noticed your act of kindness, 10 points for {}!".format(house))
            points += 10
            stop = False
        elif neville == "n":
            print("\nYour lack of chivalry did not go unnoticed by Dumbledore. 10 points from {}.".format(house))
            points -=10
            stop = False
        else:
            print("\nPlease enter 'y' for YES, 'n' for NO...")

    time.sleep(2)
    show_points(name,house,points)
    print("\nOkay, time to go shopping! I made you a list:\n")
    time.sleep(1)
    shopping_list(name,house,points)
    

def shopping_list(name,house,points):
    shop_list = ['parchment', 'quill', 'ink']
    for item in shop_list:
        print item

    time.sleep(2)
    print("\nWhat's that? You need to exchange your currency to wizard money?")
    time.sleep(1)
    print("\nOkay, no problem! Let's stop at Gringott's.")
    time.sleep(2)
    bank(name,house,points)

def bank(name,house,points):
    stop = True
    dollar = 0
    while stop:
        try:
            if dollar == 0:
                
                x = raw_input("How much do you want to convert? Just enter a number.\n")
                dollar = float(x)

                knut = dollar * 5
                sickle = dollar * 2.5
                galleon = dollar / float(2)

                print("\nPerfect! With this amount, we can get:\n\n" + str(galleon) + " galleons,")
                print(str(sickle) + " sickles,")
                print("or " + str(knut) + " knuts!\n")
                stop = False
                break
        
        except ValueError:
            print("Sorry, I didn't understand. Please just enter a plain number; no dollar signs, etc.")
            
    time.sleep(2)        
    print("Well, it looks like we have everything we need! Let's head back to the castle.")
    time.sleep(2)
    divination(name,house)


def divination(name,house):
    x = randint(1,10)
    y = randint(1,10)

    a = x % 3
    b = y % 3

    print("\nLook! some second years are practicing divination. Let's let them read our fortune!")
    time.sleep(2)
    print("\nClose your eyes and concentrate...")
    time.sleep(2)
    print("I'm seeing something... keep concentrating...\n\n")
    time.sleep(2)

    if a == 1 and b == 2:
        print ("Eureka! I see it clearly.. you will invent a potion that will make you rich!\n")
    elif a == 0 or b == 1:
        print ("Aha! Yes, it is written in the stars.. you will find your true love here at Hogwarts!\n")
    elif a == 1 and not b == 2:
        print ("Yes.. I see it.. you will achieve your quest for greatness!\n")
    else:
        print("Oh no.. doom... DOOOOOOOOOOOOOOOOMMMMM!!!!\n")

    time.sleep(2)
    print ("Haha, all in good fun, and you made some new friends!\n")
    time.sleep(2)
    print ("Okay, {}, it looks like you are all set to begin your first year at Hogwarts! Best of luck to you, my friend!\n").format(name)
    again(name,house)


def show_points(name,house,points):
    print("\nTotal points for {}: {}".format(house,points))

def again(name,house):
    stop = True
    while stop:
        replay = raw_input("Do you want to play again? y/n:\n").lower()
        if replay == "y":
            stop = False
            reset(name,house)
        if replay == "n":
            print ("Bye, {}, until next time!").format(name)
            stop = False
            exit()
        else:
            print("I didn't quite get that. Please enter 'y' for yes or 'n' for no.")

def reset(name,house):
    name = ""
    house = ""
    start(name,house)




          
        
    



if __name__ == "__main__":
    start()

