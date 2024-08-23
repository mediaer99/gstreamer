/* GStreamer
 * Copyright (C) 2022 Seungha Yang <seungha@centricular.com>
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Library General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Library General Public License for more details.
 *
 * You should have received a copy of the GNU Library General Public
 * License along with this library; if not, write to the
 * Free Software Foundation, Inc., 51 Franklin St, Fifth Floor,
 * Boston, MA 02110-1301, USA.
 */

#pragma once

#include <gst/gst.h>

G_BEGIN_DECLS

typedef enum
{
  KB_ARROW_UP = 0,
  KB_ARROW_DOWN,
  KB_ARROW_LEFT,
  KB_ARROW_RIGHT,
} VirtualKeyValue;

typedef void (*KeyInputCallback) (gchar input, gboolean is_ascii, gpointer user_data);

void set_key_handler (KeyInputCallback callback, gpointer user_data);

void unset_key_handler (void);

G_END_DECLS
