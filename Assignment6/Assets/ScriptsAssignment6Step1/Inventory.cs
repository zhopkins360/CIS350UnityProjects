﻿/*
*Zackary Hopkins
*Assignment 6
*Creates a inventory list of InventoryItems 
*
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Inventory : MonoBehaviour
    {
        [SerializeField] private InventoryItem item;
        public List<InventoryItem> inventory;


        // Use this for initialization
        void Start()
        {
            item = new InventoryItem();
            inventory = new List<InventoryItem>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
