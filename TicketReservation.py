#definitions and declarations
class customer:
    username = ""
    phone = 00000000000
    enrollment = 0


class tickets:
    ticketnumber = 0
    bookingname = ""


ticketsarray = []
customersarray = []

def bookticket(username):
    t1 = tickets()
    t1.bookingname = username
    t1.ticketnumber += 1
    ticketsarray.append(t1)
    print ("Ticket Booked.")

def cancelbooking(username):
    for ticket in ticketsarray:
        if ticket.bookingname == username:
            ticketsarray.remove(ticket)
            print ("Ticket Cancelled")
        else:
            print ("Ticket Does not Exist")

while(1):
    print ("====================================================")
    print ("Welcome to tickets reservation system")
    print ("Enter:")
    print ("1. Book A Ticket")
    print ("2. Cancel A Booked Ticket")
    print ("3. See Booked Tickets")
    print ("4. Exit")
    choice = int(input())
    if choice == 1:
        print ("Enter your username:")
        username = input()
        print ("Enter your phone number:")
        phone = input()
        c1 = customer()
        c1.username = username
        c1.phone = phone
        c1.enrollment+=1
        customersarray.append(c1)
        bookticket(c1.username)
    elif choice == 2:
        print ("Enter your username:")
        username = input()
        cancelbooking(username)
        for customer in customersarray:
            if customer.username == username:
                customersarray.remove(customer)
    elif choice == 3:
            if len(ticketsarray) != 0:
                print ("Tickets booked: ", len(ticketsarray))
                for ticket in ticketsarray:
                    print ("Username: ", ticket.bookingname)
                    print ("Ticket Number: ", ticket.ticketnumber)
            else:
                print ("Zero tickets booked yet")
    elif choice == 4:
        break
