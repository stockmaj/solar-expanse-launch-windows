# Changelog

All notable changes to this project will be documented in this file.
The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [Unreleased]

## [1.1.0] - 2026-06-06
### Added
- From dropdown is now a typeahead: opens with a filter box, list sorted alphabetically.

### Changed
- Lambert calculations now run in parallel across destinations; typical load time 4–5× faster on multi-core machines.
- Notification history panel now renders on top of the Launch Windows panel when both are open.

### Fixed
- Launch Windows button no longer snaps to the bottom-left corner when no other mod buttons are present; falls back to the notification history button as its anchor.
- Search box no longer drops the first character or lags behind fast typing (results now update once per frame rather than on every keystroke).
- Calculating overlay is now correctly hidden on all early-return paths in DoRefresh.

## [1.0.0] - 2026-06-03
### Added
- Initial release.
- Launch Windows panel showing optimal and fastest transfer windows for all planets.
- Second row per destination with next synodic-period window for longer-term planning.
- From dropdown to change origin body.
- Craft dropdown to set Δv budget; destinations outside budget shown in red.
- My Bases button to auto-add bodies where the player has built facilities.
- Body search to add any celestial body to the table.
- Calculating overlay shown during background Lambert grid computation.
- Data clears immediately on origin or craft change so stale values are never visible.
