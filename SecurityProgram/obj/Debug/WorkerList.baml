   M S B A M L   `   `   `  ����J  FSecurityProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SecurityProgramSecurityProgram  5   	        SecurityProgram.WorkerList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SecurityProgram     5   	   -   5        $��workersWindow��5        � Title$  
WorkerList��6	   $	��300��61   $	��500��6>   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��90* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��workersList��5      $��0��6T   $��0��6a   $��3��6q   �� 5   
   $��Фамилия��6   $��1��6#   $��0��60   �� 5   
   -   5        $��lastNameTextBox��5      $��2��6)   $��0��66   �� 5   
   $��Имя��6   $��1��6   $��1��6,   �� 5   
   -   5        $��nameTextBox��5      $��2��6%   $��1��62   �� 5   
   $��Отчество��6   $��1��6$   $��2��61   �� 5   
   -   5        $��midleNameTextBox��5      $��2��6*   $��2��67   �� 5   
    �� TextAlignment$ Center=�6   $��Должность ->��6+   $��4��6?   $��1��6L   �� 5   
   -   5        $��positionTextBox��5      $��4��6)   $��2��66   �� 5    
   -   5        $+��%Добавить сотрудника��5       $��3��6/   $��0��6<   6L   �� 5!   
   -   5        $)��#Удалить сотрудника��5!      $��3��6.   $��1��6;   6K   �� 5"   
   -	   5        $5��/Редактировать сотрудника��5"      $��3��64   $��2��6A   6Q   �� 5$   
   -
   5        $-��'Отметить сотрудников��5$      $��4��60   $��0��6=   6M   5%      5&      