   M S B A M L   `   `   `  ����C  ?WPFnotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFnotesWPFnotes  5          WPFnotes.HomePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WPFnotes     5      -   5        ���#FAFAFA.��5
      �� -   5          ��Name$
  Home��5
      $��Times New Roman)�6   $��16(�6<   .@�5   
   �� $��Заметки��6   .��5      � ���#FAFAFA.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgNotes��5         
IsReadOnly$
 True��6,      CanUserResizeColumns$ False��6>      AutoGenerateColumns$ False��6[   $	��Top=�6w   $	��380��6�   $
��Bold"�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Время изменения��6U      Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 6n      
FontWeight$ Normal"�6{   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6-   �� 
 �� Path$
 CreationDate�6�     5      $ Название��6Q   $ * 6c   $ Normal"�6m   	 6-   �� $
 NameNote�   ElementStyle 5      �� 5   "    �� 
TargetType" ��6(   .�5   &   ��  �� Property � �� �� Value$
 Wrap=�6E   6T   5   #   5        5      $ Тег��6Q   $	 200 6^   $ Normal"�6j   	 6-   �� $
 TagsNote� 5      �� 5   "   " ��6(   .�5   &   ��  � ��$
 Wrap=�6E   6T   5   #   5      5      �� 5       -   5         ��Name$ 
CreateNote��5       $#��Создать заметку��6-   $��Bottom=�6G   $��10q�6b   $��20(�6n   $
��Bold"�6|   
�������$	��200��6�   $��30��6�   ���#1F50AD6�   5!      5"      �� 5#   
   $��Напоминания��6   .��5$      � ���#FAFAFA.+�5%        -   5        $ 	dgPrompts��5%      $
 True��6.   $ False��6@   $ False��6]   $	��Top=�6y   $	��380��6�   $
��Bold"�6�    5&        5'      $! Время создания��6U   $	 180 6m   $ Normal"�6z   	 6-   �� $
 CreationDate�6�     5(      $# Время окончания��6W   $	 180 6p   $ Normal"�6}   	 6-   �� $
 ExpirationDate�6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5)      $
 Push��6Q   $ 50 6_   	 61   �� $

 Push�6l     5*      $ Напоминание��6S   $ * 6h   $ Normal"�6r   	 6-   �� $
 
TextPrompt� 5+      �� 5,   "   " ��6(   .�5-   &   ��  � ��$
 Wrap=�6E   6T   5.   #   50        51      $ Тег��6S   $	 200 6`   $ Normal"�6l   	 6-   �� $
 
TagsPrompt� 52      �� 53   "   " ��6(   .�54   &   ��  � ��$
 Wrap=�6E   6T   55   #   57      59      �� 5:      -   5        $ CreatePrompt��5:      $/��)Поставить напоминание��6/   $��Bottom=�6O   $��10q�6j   $��20(�6v   $
��Bold"�6�   
�������$	��250��6�   $��30��6�   ���#1F50AD6�   5;      5<      �� 5=   
   $��Теги��6   .��5>      � ���#FAFAFA.+�5?        -   5        $ dgTags��5?      $
 True��6+   $ False��6=   $ False��6Z   $	��Top=�6v   $	��380��6�   $
��Bold"�6�    5@        5A      $ Список тегов��6Q   $ * 6g   $ Normal"�6q   	 6-   �� $
 NameTags� 5B      �� 5C   "   " ��6(   .�5D   &   ��  � ��$
 Wrap=�6E   6T   5E   #   5G      5I      �� 5J      -   5        $ 
CreateTags��5J      $��Добавить тег��6-   $��Bottom=�6D   $��10q�6_   $��20(�6k   $
��Bold"�6y   
�������$	��200��6�   $��30��6�   ���#1F50AD6�   5K      5L      5M      5N      