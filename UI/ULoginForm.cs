﻿using BookHeaven2.Data.Models;
using BookHeaven2.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHeaven2.UI
{
    public partial class ULoginForm : Form
    {
        private readonly UserService _userService;

        public ULoginForm(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //var user = new AppUser
            //{
            //    Id = Guid.NewGuid(),
            //    PasswordHash = password,
            //    Username = username,
            //    Role = UserRole.Admin
            //};

            //await _userService.CreateUserAsync(user);

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            if (username.Length < 3 || password.Length < 3)
            {
                lblError.Text = "Username and password must be at least 3 characters long.";
                return;
            }

            var user = await _userService.ValidateUserAsync(username, password);
            if (user != null)
            {
                lblError.Text = "";

                var userExist = await _userService.ValidateUserAsync(username, password);
                if (userExist != null)
                {
                    if (userExist.Role == UserRole.Admin) {
                        var adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                    }

                    if (userExist.Role == UserRole.SalesClerk) {
                        var clerkForm = new ClerkForm();
                        clerkForm.Show();
                        this.Hide();
                    }

                    
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");

                }

            }
            else
            {
                lblError.Text = "Invalid email or password.";
            }

        }
    }
}
