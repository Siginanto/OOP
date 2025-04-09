class Stack:
    def __init__(self, size=10):
        self.size = size
        self.stack = [None] * size
        self.top_index = -1  # Индекс вершины стека
    
    def push(self, value):
        """Добавление элемента в стек"""
        if self.top_index == self.size - 1:
            print("Ошибка: Стек переполнен")
            return
        self.top_index += 1
        self.stack[self.top_index] = value
    
    def pop(self):
        """Удаление и возврат элемента из стека"""
        if self.is_empty():
            print("Ошибка: Стек пуст")
            return None
        value = self.stack[self.top_index]
        self.top_index -= 1
        return value
    
    def top(self):
        """Возврат элемента на вершине стека без удаления"""
        if self.is_empty():
            print("Ошибка: Стек пуст")
            return None
        return self.stack[self.top_index]
    
    def is_empty(self):
        """Проверка, пуст ли стек"""
        return self.top_index == -1
    
    def __str__(self):
        """Строковое представление стека для отладки"""
        if self.is_empty():
            return "[]"
        return str(self.stack[:self.top_index + 1])

# Использование

# stack = Stack(3)  # Создаем стек размером 3
# 
# print(stack.is_empty())  # True
# 
# stack.push(1)
# stack.push(2)
# stack.push(3)
# 
# print(stack.top())  # 3
# print(stack.pop())  # 3
# print(stack.pop())  # 2
# 
# stack.push(4)
# print(stack)       # [1, 4]
# 
# print(stack.pop())  # 4
# print(stack.pop())  # 1
# print(stack.pop())  # Ошибка: Стек пуст, None
# 
# stack.push(5)
# stack.push(6)
# stack.push(7)
# stack.push(8)       # Ошибка: Стек переполнен