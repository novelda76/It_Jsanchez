   M S B A M L   `   `   `  ����D  @WPF.Start, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPF.Start.ViewsWPF.Start.Views  5      #    WPF.Start.Views.SubjectViewUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      )localclr-namespace:WPF.Start.Views  5      .��5
      � ���	#FFE5E5E5  � ColumnDefinitions  5   
   �� 5      $	��400 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $"��WELCOME SUBJECT MAIN PLACE!!��65   $
��Wrap=�6Y   $	��Top=�6m   $	��252��6�   $��16(�6�   $��	0,121,0,0q�6�   �� 5      $
��Left=�6   $��26��61   $��
98,190,0,0q�6=    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��268��6�   ��6Q   �� *Name+ �� Mode$ TwoWay=�6�   �� 5      $
��Left=�6   $��
22,192,0,0q�63   $��Name:��6G   $
��Wrap=�6T   $	��Top=�6h   $��60��6�   $��26��6�    �� TextAlignment$ Right=�6�   $��14(�6�   �� 5      $��Register��65   $
��Left=�6H   $��
98,300,0,0q�6c   $	��Top=�6w   ���	#FF0097FF$��32��6�   $	��134��6�   ��6   �� *SaveCommand+6�   �� 5      $��Clear��66   $
��Left=�6F   $��232,300,0,0q�6a   $	��Top=�6v   ���	#FF0097FF$��32��6�   $	��131��6�   ��6   �� *ClearCommand+6�   �� 5      $
��Left=�6   $5��/The number of subjects in db at this moment is:��63   $
��Wrap=�6j   $	��Top=�6~   $��10(�6�   $��
40,435,0,0q�6�   �� 5      $
��Left=�6   $7��1The number of subjects in dict at this moment is:��63   $
��Wrap=�6l   $	��Top=�6�   $��10(�6�   $��
40,471,0,0q�6�   �� 5      $
��Left=�67   $��260,428,0,0q�6R   $	��Top=�6g   ��6   �� *Subjects.Count+6g   �� 5      $
��Left=�62   $��260,464,0,0q�6M   $	��Top=�6b   ��6   �� *	SbjInDict+6b   �� 5       �� DisplayMemberPath$
 Name��6@   $
��Left=�6�   $��
98,248,0,0q�6�   $	��Top=�6�   $	��265��6�   ��6   �� *TeachersToSelect+ �� SelectedValue 6Y   �� *TeacherSelected+6�   �� 5       $
��Left=�6   $��
22,246,0,0q�63   $��Teacher:��6G   $
��Wrap=�6W   $	��Top=�6k   $��60��6�   $��26��6�   $ Right=�6�   $��14(�6�   5"      � 5$   
   $��1��6   .+�5&      &   System.Windows.Controls.DataGrid  $��5q�6`      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6k      AutoGenerateColumns$ False��6}   ��6   �� *
Subjects+ �� SelectedItem 68   �� *CurrentSubject+.  (System.Windows.Interactivity.Interaction	   Triggers	 5(      /  )System.Windows.Interactivity.EventTrigger  5)      
   	EventName$
 Loaded��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5*      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *GetInfoCommand+5+         Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6)      Width$ * 6P   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 67   �� *Name+6P     50      $ Teacher��6)   $ * 6Z    6:   �� *TeacherName+6Z     51      $ Id��6)   $	 300 6L    65   �� *Id+6L   5G      5I      5K      5L      