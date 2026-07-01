# Research Knowledge Cards

## Contract

Research Knowledge Capture Contract:
- External research is allowed only through bounded source cards. Agents must not paste full web pages, copied article text, competitor screenshots, or unverified claims into downstream context.
- Preferred owners: ux-researcher for player/product/gameplay references; evidence-collector for source-card evidence, attribution, and license risk; technical-artist for asset feasibility; product-experience-reviewer for product-experience synthesis.
- Required knowledge base reads when research is used: research_capture/ROUTING.md, research_capture/SOURCE_CARD_SCHEMA.md, research_capture/VALIDATION_GATES.md, and research_capture/LICENSE_AND_ATTRIBUTION.md.
- Required project outputs when external research is used: docs/research/Research_Source_Cards.md, docs/research/Research_Synthesis.md, docs/research/Research_License_Risk_Register.md, and status/context/research_context_pack.md.
- Each source card must include source_card_id, source_title, source_url, publisher_or_author, accessed_at, source_type, license_or_terms, usage_risk, recommended_for_stage, usable_summary, design_implication, do_not_use_directly, and open_questions.
- Planning and Spec Review must cite source card ids or bounded internal knowledge-base paths for research-based claims.
- Development may directly use external assets only when a source card marks usage_risk=low and direct_asset_use_allowed=true.
- QA must fail if a product claim, asset, platform rule, or product-experience benchmark depends on external research but no source card or license risk record exists.

## Initial Cards

```yaml
source_card_id: internal-kb-game-quality-001
source_title: OpenClaw Game Quality Knowledge Base
source_url: /home/node/.openclaw/workspace/public_document/knowledge_base/game_quality/README.md
publisher_or_author: OpenClaw internal
accessed_at: define-time
source_type: internal_knowledge_base
license_or_terms: internal project guidance
usage_risk: low
recommended_for_stage: planning, spec_review, development, qa
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: Use GAMEPLAY_DEPTH.md, VISUAL_RICHNESS.md, QUALITY_RUBRIC.md, and VALIDATION_GATES.md as bounded quality references.
- design_implication: Planning must turn quality goals into concrete player actions, system responses, feedback events, and QA evidence.
- do_not_use_directly: Do not paste whole knowledge-base files into downstream handoffs.
- open_questions: Project-specific benchmark sources still need research capture if Raw Idea asks for external inspiration.

```yaml
source_card_id: internal-kb-research-capture-001
source_title: OpenClaw Research Capture Knowledge Base
source_url: /home/node/.openclaw/workspace/public_document/knowledge_base/research_capture/README.md
publisher_or_author: OpenClaw internal
accessed_at: define-time
source_type: internal_knowledge_base
license_or_terms: internal project guidance
usage_risk: low
recommended_for_stage: raw_idea, define, planning, spec_review, development, qa
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: External research must become source cards with source URL, accessed date, license/terms, usage risk, usable summary, design implication, and do-not-use-directly notes.
- design_implication: Agents may search the web, but downstream stages consume only source cards and synthesis.
- do_not_use_directly: Do not use raw external pages or unlicensed assets as production input.
- open_questions: External references supplied by user must be converted into full source cards before direct downstream use.

```yaml
source_card_id: raw-reference-pending-001
source_title: No explicit raw reference provided
source_url: (not provided)
publisher_or_author: unknown
accessed_at: pending_research_capture
source_type: other
license_or_terms: unknown
usage_risk: medium
recommended_for_stage: define, planning
direct_asset_use_allowed: false
direct_text_use_allowed: false
```

- usable_summary: Pending. A research owner must inspect and summarize this reference if it affects product direction.
- design_implication: Treat as inspiration only until converted into validated source card.
- do_not_use_directly: Do not copy text, images, audio, UI, or product claims from this reference before license and source review.
- open_questions: Verify source URL, author/publisher, license/terms, and applicable design implication.

## Required Downstream Outputs

- docs/research/Research_Source_Cards.md
- docs/research/Research_Synthesis.md
- docs/research/Research_License_Risk_Register.md
- status/context/research_context_pack.md
