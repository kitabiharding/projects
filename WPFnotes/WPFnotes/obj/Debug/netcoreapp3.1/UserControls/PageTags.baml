   M S B A M L   `   `   `  ����C  ?WPFnotes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WPFnotes.UserControlsWPFnotes.UserControls  5      $    WPFnotes.UserControls.PageTags   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:WPFnotes.UserControls     5      -   5        ���#FAFAFA.��5
      � .+�5   
   �� $��	20 20 0 0q�6   $��Times New Roman)�6#   $��16(�6@   $
��Bold"�6N   .��6`   Выбранный тег:6p   �� 5   
   -   5          ��Name$  	tbNameTag��5      $��150 24 20 0q�6%   $	��Top=�6:   ���#FFFFFF$��Times New Roman)�6g   $��16(�6�    �� 
IsReadOnly$
 True��6�   6�   �� 5   
   -   5         ��Name$
 Home��5      $��Times New Roman)�6#   $��16(�6@   $��0 60 0 0q�6N   $	��Top=�6`   .@�5      �� $��Заметки��6   .��5      � ���#FAFAFA.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgNotes��5         
IsReadOnly$
 True��60      CanUserResizeColumns$ False��6B      AutoGenerateColumns$ False��6_   $	��Top=�6{   $
��Bold"�6�   $	��300��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Время изменения��6Y   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 180 6r   
   
FontWeight$
 Normal"�6   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$ CreationDate�6�     5      $ Название��6U   $	 * 6g   $
 Normal"�6q    61   �� $ NameNote�   ElementStyle 5   "   �� 5   &    �� 
TargetType" ��6,   .�5   *   ��  �� Property � �� �� Value$
 Wrap=�6I   6X   5   '   5        5      $ Тег��6U   $		 225 6b   $
 Normal"�6n    61   �� $ TagsNote� 5   "   �� 5   &   " ��6,   .�5   *   ��  � ��$
 Wrap=�6I   6X   5   '   5       5"      5#      5$      �� 5%      $��Напоминания��6   .��5&      � ���#FAFAFA.+�5'        -   5        $ 	dgPrompts��5'      $
 True��62   $ False��6D   $ False��6a   $	��Top=�6}   $
��Bold"�6�   $	��300��6�    5(        5)      $! Время создания��6Y   $		 180 6q   $
 Normal"�6~    61   �� $ CreationDate�6�     5*      $# Время окончания��6[   $		 180 6t   $
 Normal"�6�    61   �� $ ExpirationDate�6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5+      $
 Push��6U   $	 50 6c    65   �� $
 Push�6p     5,      $ Напоминание��6W   $	 * 6l   $
 Normal"�6v    61   �� $ 
TextPrompt� 5-   "   �� 5.   &   " ��6,   .�5/   *   ��  � ��$
 Wrap=�6I   6X   50   '   52      54      55      56      57      �� 58   
   -   5         ��Name$ 	TagDelete��58      $(��"Удалить данный тег��6$   $��Bottom=�6A   $��-250 0 0 13q�6\   $��20(�6q   $
��Bold"�6   
�������$	��300��6�   $��30��6�   $��Times New Roman)�6�   ���#1F50AD6�   �� 59   
   -   5        $
 Back��59      $#��Вернуться назад��6   $��Bottom=�69   $��
350 0 0 13q�6T   $��20(�6h   $
��Bold"�6v   
�������$	��200��6�   $��30��6�   $��Times New Roman)�6�   ���#1F50AD6�   5:      5;      